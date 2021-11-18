# gestao.cliente


PROJETO DE ESTDUDO

- Criar um sistema de gestão de cliente
	vamos gerenciar os clientes, com endereço e contato
	
Cliente
- Cadastro
	- Id
		- int
		- deve gerar automatico
	- Nome
		- varchar(100)
	- Data de nscimento
		- DateTime
		- default 
	- Genero
		- varchar(20)
		
	- Metodo: Salvar(objeto cliente);
- Atualização
	- Nome
	- Data de nscimento
	- Genero
		
	- Metodo: Atualizar(objeto cliente);
- Remoção
	- Id
		
	- Metodo: Excluir(int id);
- Listar
	- Listar os seguintes dados: Id, Nome
		
	- Metodo: ListarPor(int id, string nome);
- Obter
	- Lista todos os dados
		
	- Metodo: ObterPor(int id);

- Validações:
	Obrigatoriedade: Nome, Data de nascimento



Endereço 
- Cadastro
	- Id
		- int
		- deve gerar automatico
	- Logradouro
		- varchar(100)
	- Numero
		- varchar(50)
	- Complemento
		- varchar(50)
	- Cep
		- varchar(10)
	- Estado
		- varchar(2)
	- Cidade 
		- varchar(100)
	- Bairro
		- varchar(100)
		
	- Metodo: Salvar(objeto endereco);
- Atualização
	- Logradouro
	- Numero
	- Complemento
	- Cep
	- Estado
	- Cidade 
	- Bairro
	
	- Metodo: Atualizar(objeto endereco);
- Remoção
	- Id
	
	- Metodo: Excluir(int id);
- Listar
	- Listar os seguintes dados: Id, Logradouro, Cep e Estado
		
	- Metodo: ListarPor(int id, string cep);
- Obter
	- Lista todos os dados
		
	- Metodo: ObterPor(int id);

- Validações:
	Obrigatoriedade: Logradouro e Cep


Contato
- Cadastro
	- Id
		- int
		- deve gerar automatico
	- Telefone
		- varchar(14)
	- E-mail
		- varchar(100)
		
	- Metodo: Salvar(objeto contato);
- Atualização
	- Telefone
	- E-mail
	
	- Metodo: Atualizar(objeto contato);
- Remoção
	- Id
- Listar
	- Listar os seguintes dados: Id, Telefone e E-mail
		
	- Metodo: ListarPor(int id, string email);
- Obter
	- Lista todos os dados
		
	- Metodo: ObterPor(int id);
	
- Validações:
	Obrigatoriedade: E-mail
	
	
Quais sao as tecnologias utilizadas no projeto?
- ASP.NET 5.0
	- API
	- Painel Web
- Banco de dados SQL Server
	- Tabelas
- Dapper
	- ORM para gerenciar os dados no repositorio

	
- UI
	- Web
- Aplication
	- Serviços
- Dommin
	- Validações
	- Interfaces
	- Entidade
- Infra
	- Data
		- Repositorios
	- IoC

