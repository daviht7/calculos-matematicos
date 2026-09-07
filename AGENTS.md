# Diretrizes do Projeto

Este repositorio utiliza .NET 8 e deve ser trabalhado pelo agente autonomo definido em `.github/agents/dotnet8-autonomous.agent.md`.

## Regra principal

O agente deve executar a demanda completa: analisar o repositorio, planejar, editar arquivos, implementar a feature, criar testes, validar, versionar e preparar ou publicar o Pull Request. O usuario nao deve precisar escrever codigo.

## Escopo tecnologico

- .NET 8 e C#.
- ASP.NET Core, Entity Framework Core e APIs REST quando presentes no repositorio.
- Testes unitarios, de integracao e de contrato conforme os padroes existentes.
- Git e GitHub para branches, commits e Pull Requests.

## Fluxo obrigatorio

1. Inspecionar a solucao antes de editar.
2. Verificar o estado do Git e preservar alteracoes existentes.
3. Criar ID, slug, branch e pasta de historico da demanda.
4. Registrar a solicitacao, analise e plano antes da implementacao.
5. Implementar a menor solucao consistente com a arquitetura existente.
6. Criar ou atualizar testes.
7. Executar restore, build, testes e validacoes aplicaveis.
8. Registrar cada resultado no historico.
9. Criar commits focados e o Pull Request quando houver autenticacao e remoto disponiveis.
10. Usar `staging` como branch base; toda nova feature deve sair de `staging` e ter Pull Request direcionado para `staging`.

## Historico obrigatorio

Cada demanda deve usar:

`.agent/history/<id>-<slug>/`

Com os arquivos:

- `00-request.md`
- `01-analysis.md`
- `02-plan.md`
- `03-implementation.md`
- `04-validation.md`
- `05-pull-request.md`

## Qualidade e seguranca

- Respeitar a arquitetura, convencoes e APIs publicas existentes.
- Nao fazer refatoracoes fora do escopo sem justificativa.
- Nao incluir credenciais, tokens ou dados sensiveis em arquivos, commits ou PRs.
- Nao remover dados ou arquivos de forma destrutiva sem autorizacao explicita.
- Nao alterar producao diretamente.
- Registrar bloqueios reais em vez de simular uma conclusao.
