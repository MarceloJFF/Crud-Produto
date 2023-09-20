
# Passo a Passo para Rodar o Projeto

Siga estas etapas para configurar e rodar o projeto em seu ambiente local.

## Passo 1: Instalar as Ferramentas Necessárias

1. **Visual Studio**: Baixe e instale o [Visual Studio](https://visualstudio.microsoft.com/downloads/) em seu computador.

2. **SQL Server**: Baixe e instale o [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) em seu computador.

## Passo 2: Criar o Banco de Dados

1. Abra o SQL Server Management Studio (SSMS) após a instalação.

2. Conecte-se ao servidor SQL local ou ao servidor que você configurou.

3. No SSMS, abra uma nova consulta e execute o seguinte comando SQL para criar o banco de dados "BancoProduto":

   ```sql
   CREATE DATABASE BancoProduto;

## Passo 3: Criar a Tabela "Product" no Banco de Dados
Certifique-se de que o banco de dados "BancoProduto" esteja selecionado como banco de dados de contexto na barra suspensa no SSMS.

Na mesma janela de consulta, cole e execute o seguinte comando SQL para criar a tabela "Product" dentro do banco de dados "BancoProduto":

sql  
Copy code  
USE BancoProduto;  

CREATE TABLE [dbo].[Product](  
    [Id] [int] NOT NULL,  
    [Name] [varchar](255) NULL,  
    [Quantity] [int] NULL,  
    [Price] [decimal](10, 2) NULL,  
    [Description] [varchar](500) NULL,  
PRIMARY KEY CLUSTERED   
(  
    [Id] ASC  
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]   
);  
Após concluir essas etapas, seu ambiente local estará configurado com o Visual Studio, o SQL Server e o banco de dados "BancoProduto". Agora você pode prosseguir com a configuração e execução do seu projeto. 

## Passo 4: Configurar o arquivo App.Config
No diretório entre em App.Config E altere a String de conexão para sua forma forma de conexão com Sql Server.
```<?xml version="1.0" encoding="utf-8" ?>
<configuration>
	<connectionStrings>
		<add name="MyConnection" connectionString="" />
	</connectionStrings>
</configuration>
```
## Passo 5: Rode  o Projeto
Rode o arquivo Crud ```Produto.csproj
