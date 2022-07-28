CREATE TABLE cidades (
    "Id" serial NOT NULL,
    "Nome" text NOT NULL,
    "NomeEstado" text NOT NULL,
    CONSTRAINT "PK_cidades" PRIMARY KEY ("Id")
);

CREATE TABLE clientes (
    "Id" serial NOT NULL,
    "Nome" character varying(120) NOT NULL,
    "CNPJ" text NOT NULL,
    "DtNascimento" timestamp with time zone NOT NULL,
    "DtCadastro" timestamp with time zone NOT NULL,
    CONSTRAINT "PK_clientes" PRIMARY KEY ("Id")
);

CREATE TABLE "clienteEnderecos" (
    "Id" serial NOT NULL,
    "TpEndereco" character(1) NOT NULL,
    "Logradouro" text NOT NULL,
    "Bairro" text NOT NULL,
    "Numero" text NOT NULL,
    "Cep" text NOT NULL,
    "cidadeId" integer NOT NULL,
    "ClientesId" integer NULL,
    CONSTRAINT "PK_clienteEnderecos" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_clienteEnderecos_cidades_cidadeId" FOREIGN KEY ("cidadeId") REFERENCES cidades ("Id") ON DELETE CASCADE,
    CONSTRAINT "FK_clienteEnderecos_clientes_ClientesId" FOREIGN KEY ("ClientesId") REFERENCES clientes ("Id")
);

CREATE TABLE "clienteFones" (
    "Id" serial NOT NULL,
    "Telefone" text NOT NULL,
    "Contato" text NOT NULL,
    "ClientesId" integer NULL,
    CONSTRAINT "PK_clienteFones" PRIMARY KEY ("Id"),
    CONSTRAINT "FK_clienteFones_clientes_ClientesId" FOREIGN KEY ("ClientesId") REFERENCES clientes ("Id")
);