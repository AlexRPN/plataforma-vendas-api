# 🛒 Plataforma de Vendas - API

API para gerenciamento de plataforma de vendas desenvolvida com .NET 10.

## 📋 Pré-requisitos

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- SQL Server ou SQL Server LocalDB
- Visual Studio 2026 (recomendado) ou Visual Studio Code

## 🚀 Configuração Inicial

### 1. Clone o repositório

```powershell
git clone https://github.com/AlexRPN/plataforma-vendas-api
cd plataforma-vendas-api/PlataformaVendas
```

### 2. Restaure os pacotes NuGet

```powershell
dotnet restore
```

### 3. Configure a connection string local

O projeto utiliza **User Secrets** para gerenciar configurações sensíveis em desenvolvimento.

```powershell
cd PlataformaVendas
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\mssqllocaldb;Database=PlataformaVendas;Trusted_Connection=True;TrustServerCertificate=True;"
```

**Para SQL Server completo, use:**
```powershell
dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=SEU_SERVIDOR;Database=PlataformaVendas;Trusted_Connection=True;TrustServerCertificate=True;"
```

### 4. Crie o banco de dados

Execute as migrations para criar o banco de dados e as tabelas:

```powershell
cd ..\PlataformaVendas.Ioc
dotnet ef database update --startup-project ..\PlataformaVendas\PlataformaVendas.Api.csproj
```

**Ou, a partir da raiz do projeto:**
```powershell
dotnet ef database update --project PlataformaVendas.Ioc\PlataformaVendas.Infra.csproj --startup-project PlataformaVendas\PlataformaVendas.Api.csproj
```

### 5. Execute a aplicação

```powershell
cd PlataformaVendas
dotnet run
```

A API estará disponível em:
- HTTPS: `https://localhost:5001`
- HTTP: `http://localhost:5000`

## 📁 Estrutura do Projeto

```
PlataformaVendas/
├── PlataformaVendas/               # Projeto API (Startup)
│   ├── Controllers/                # Controllers da API
│   ├── Program.cs                  # Configuração da aplicação
│   └── appsettings.json            # Configurações gerais
├── PlataformaVendas.Dominio/       # Camada de domínio (Entities, Interfaces)
├── PlataformaVendas.Infra/         # Camada de infraestrutura (Data Access)
│   ├── Data/                       # DbContext
│   └── Migrations/                 # Migrations do EF Core
├── PlataformaVendas.DataTransfer/  # DTOs (Data Transfer Objects)
└── PlataformaVendas.Dominio.Testes/ # Testes unitários
```

## 🗄️ Migrations

### Criar uma nova migration

```powershell
cd PlataformaVendas.Ioc
dotnet ef migrations add NomeDaMigracao --startup-project ..\PlataformaVendas\PlataformaVendas.Api.csproj
```

### Aplicar migrations

```powershell
dotnet ef database update --startup-project ..\PlataformaVendas\PlataformaVendas.Api.csproj
```

### Reverter última migration

```powershell
dotnet ef migrations remove --startup-project ..\PlataformaVendas\PlataformaVendas.Api.csproj
```

## 🛠️ Tecnologias Utilizadas

- **.NET 10** - Framework principal
- **Entity Framework Core 10** - ORM para acesso a dados
- **SQL Server** - Banco de dados
- **ASP.NET Core** - Framework web
- **OpenAPI** - Documentação da API
- **xUnit** - Framework de testes

## 🔒 Segurança

- Connection strings sensíveis são gerenciadas via **User Secrets** em desenvolvimento
- Em produção, utilize **Variáveis de Ambiente** ou **Azure Key Vault**

## 📝 Notas Importantes

- O arquivo `appsettings.Development.json` contém apenas valores genéricos
- Suas configurações locais ficam protegidas em **User Secrets**
- As **migrations** devem sempre ser commitadas no Git
- Nunca commite arquivos `appsettings.Production.json` com dados sensíveis

## 🤝 Contribuindo

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/MinhaFeature`)
3. Commit suas mudanças (`git commit -m 'Adiciona MinhaFeature'`)
4. Push para a branch (`git push origin feature/MinhaFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença [MIT](LICENSE).

## 👤 Autor

**Alex Nunes**
- GitHub: [@AlexRPN](https://github.com/AlexRPN)

---
