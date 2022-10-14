USE CONVIVER_SENIOR

BEGIN--CUIDADORES
	DROP TABLE CUIDADORES

	CREATE TABLE CUIDADORES
	(ID INT IDENTITY(1,1)
	,NOME VARCHAR(100)
	,ENDERECO VARCHAR(1000)
	)

	TRUNCATE TABLE CUIDADORES

	ALTER PROC INSERE_CUIDADOR
		@NOME VARCHAR(100)
		,@ENDERECO VARCHAR(1000)
	AS
	BEGIN
		INSERT INTO CUIDADORES
		VALUES (@NOME,@ENDERECO)
	END

	ALTER PROC MOSTRA_CUIDADORES	
	AS
	BEGIN
		SELECT 
			Nome as 'Nome do/a cuidador(a)'
			,ENDERECO as 'Endere�o do/a cuidador(a)'
		FROM CUIDADORES
	END

END

BEGIN--PACIENTES

	DROP TABLE PACIENTES

	CREATE TABLE PACIENTES
	(ID INT IDENTITY(1,1)
	,ID_CLIENTE INT
	,NOME VARCHAR(500)
	,ENDERECO VARCHAR(1000)
	,FLG_ATIVO VARCHAR(50)
	)

	truncate table PACIENTES	

	ALTER PROC INSERE_PACIENTE
		@ID_CLIENTE INT
		,@NOME VARCHAR(500)
		,@ENDERECO VARCHAR(1000)
		,@ATIVO VARCHAR(50)
	AS
	BEGIN
		INSERT INTO PACIENTES
		VALUES (@ID_CLIENTE,@NOME,@ENDERECO,@ATIVO)
	END

	ALTER PROC MOSTRA_PACIENTES
	AS
	BEGIN
		SELECT 
			ID			AS 'C�digo do paciente'
			,NOME		AS 'Nome do paciente'
			,ENDERECO	AS 'Endere�o do paciente'
			,FLG_ATIVO	AS 'Status do paciente'
		FROM PACIENTES
		WHERE FLG_ATIVO = 'ATIVO'
	END
END

BEGIN--CLIENTES
	DROP TABLE CLIENTES

	CREATE TABLE CLIENTES
	(ID INT IDENTITY(1,1)
	,NOME VARCHAR(100)
	,ENDERECO VARCHAR(1000)
	)

	TRUNCATE TABLE CLIENTES

	ALTER PROC INSERE_CLIENTE
		@NOME VARCHAR(100)
		,@ENDERECO VARCHAR(1000)
	AS
	BEGIN
		INSERT INTO CUIDADORES
		VALUES (@NOME,@ENDERECO)
	END

	ALTER PROC MOSTRA_CLIENTES	
	AS
	BEGIN
		SELECT 
			Nome as 'Nome do/a cliente'
			,ENDERECO as 'Endere�o do/a cliente'
		FROM CLIENTES
	END

END

BEGIN--PAGAMENTOS
	
	DROP TABLE PAGAMENTOS

	set dateformat 'dmy'

	CREATE TABLE PAGAMENTOS
	(ID INT IDENTITY(1,1)
	,ID_PACIENTE INT	
	,DATA_COBRANCA DATE
	,DATA_PAGAMENTO DATE
	,STATUS_PAGAMENTO VARCHAR(50)
	,FORMA_PAGAMENTO VARCHAR(50)
	,VALOR DECIMAL(18,2)
	,ACRESCIMO DECIMAL(18,2)
	,VALOR_FINAL DECIMAL(18,2)	
	)

	TRUNCATE TABLE PAGAMENTOS
	
	INSERT INTO PAGAMENTOS
	SELECT 1, GETDATE(), GETDATE(), 'Pago', 'Cart�o de cr�dito', 1445, 220, 1445 + 220
	
	ALTER PROC INSERE_PAGAMENTO 
		@ID_PACIENTE INT	
		,@DATA_COBRANCA DATE
		,@DATA_PAGAMENTO DATE
		,@STATUS_PAGAMENTO VARCHAR(50)
		,@FORMA_PAGAMENTO VARCHAR(50)
		,@VALOR DECIMAL(18,2)
		,@ACRESCIMO DECIMAL(18,2)
		,@VALOR_FINAL DECIMAL(18,2)	
	AS
	BEGIN
		INSERT INTO PAGAMENTOS
		VALUES (@ID_PACIENTE
		,@DATA_COBRANCA
		,@DATA_PAGAMENTO
		,@STATUS_PAGAMENTO
		,@FORMA_PAGAMENTO
		,@VALOR
		,@ACRESCIMO
		,@VALOR_FINAL		
		)
	END

	ALTER PROC MOSTRA_PAGAMENTOS
	AS
	BEGIN
		SELECT 
			*
		FROM PAGAMENTOS
	END

	ALTER PROC BUSCAR_PAGAMENTOS_POR_ID
		@ID_PACIENTE INT
	AS
	BEGIN
		SELECT 
			ID									AS 'C�digo do pagamento'
			,ID_PACIENTE							AS 'C�digo do paciente'
			,format(DATA_COBRANCA, 'dd/M/yyyy')		AS 'Data da cobran�a' 
			,format(DATA_PAGAMENTO, 'dd/M/yyyy')	AS 'Data do pagamento'
			,STATUS_PAGAMENTO						AS 'Status do pagamento'
			,FORMA_PAGAMENTO						AS 'Forma do pagamento'
			,VALOR									AS 'Valor da cobran�a'
			,ACRESCIMO								AS 'Acrescimo da cobran�a'
			,VALOR_FINAL							AS 'Valor final da cobran�a'
		FROM PAGAMENTOS 
		WHERE ID_PACIENTE = @ID_PACIENTE
	END

	ALTER PROC ATUALIZAR_PAGAMENTO_PACIENTE
		@ID INT
		,@STATUS_NOVO VARCHAR(100)
		,@FORMA_PAGAMENTO_NOVO VARCHAR(100)
		,@DATA_PAGAMENTO_NOVO DATE
	AS
	BEGIN
		UPDATE PAGAMENTOS
		SET STATUS_PAGAMENTO = @STATUS_NOVO
			,FORMA_PAGAMENTO = @FORMA_PAGAMENTO_NOVO
			,DATA_PAGAMENTO = @DATA_PAGAMENTO_NOVO
		WHERE ID = @ID
	END

	CREATE PROC ADICIONA_NOVO_PAGAMENTO_DO_MES
	AS
	BEGIN
		INSERT INTO PAGAMENTOS
			SELECT ID		AS ID_PACIENTE
			,GETDATE()+10	AS DATA_COBRANCA
			,NULL			AS DATA_PAGAMENTO
			,'Em aberto'	AS STATUS_PAGAMENTO
			,NULL			AS FORMA_PAGAMENTO
			,1000			AS VALOR
			,100			AS ACRESCIMO
			,1100			AS VALOR_FINAL
			FROM PACIENTES
	END
END



EXEC BUSCAR_PAGAMENTOS_POR_ID 1