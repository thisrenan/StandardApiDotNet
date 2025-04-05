# StandardApiDotNet

Com o fim do swagger padrão nos projetos do .NET 9, uma opção é marcar a opção OpenAPI na criação do projeto (ou propriedade caso criação via promt) para habilitar a visualização por json dos serviços:

![image](https://github.com/user-attachments/assets/76e15a0b-932f-4721-95a5-8698bc01dadb)

Você também pode customizar a url apenas dando um nome na propriedade AddOpenApi:

builder.Services.AddOpenApi("documentation");

![image](https://github.com/user-attachments/assets/12f2eff2-0eb8-4bfa-a815-6ced244f47f1)
