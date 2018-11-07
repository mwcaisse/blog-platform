USE PYDEPLOYER_LOCAL;

SELECT * FROM APPLICATION;

ALTER TABLE APPLICATION
    ADD COLUMN ENCRYPTION_KEY VARCHAR(1000) NULL;

SELECT * FROM APPLICATION_ENVIRONMENT;

SELECT * FROM APPLICATION_TOKEN;

SELECT * FROM APPLICATION_ENVIRONMENT_TOKEN;

update APPLICATION
    SET APPLICATION.ENCRYPTION_KEY = NULL;

update APPLICATION_ENVIRONMENT_TOKEN
    SET TOKEN_VALUE = 'HELLO WORLD TEST UNEC';