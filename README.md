# Hackaton-Fiap


![Arquitetura_Hackaton drawio](https://github.com/user-attachments/assets/5bde2806-573d-481c-b2c4-45df7eba0b8b)

Contaremos com o **Amazon CloudFront** para garantir uma distribuição rápida e segura de conteúdo, melhorando significativamente a performance e reduzindo a latência globalmente. 

Como parte da arquitetura, implementaremos um **API Gateway** para internalizar as requisições, encaminhando-as para um **Load Balancer** que distribui o tráfego entre os containers da API de forma balanceada. 

Optamos por **ECS Fargate** devido à facilidade de configuração e à rápida escalabilidade parametrizável. Inicialmente configuraremos duas tasks operando 24/7, com a capacidade de escalar até 15 tasks conforme necessário. Para escalar, definiremos métricas de CPU e memória para garantir um dimensionamento eficiente e adequado dos recursos do sistema. Essas métricas nos permitirão monitorar o uso dos recursos em tempo real e ajustar dinamicamente a capacidade conforme necessário, assegurando que tenhamos sempre o desempenho ideal e evitando sub ou super utilização dos recursos.

Usamos o **AWS Cognito** nessa arquitetura para gerenciar autenticação e autorização de usuários de forma segura. Ele facilita o login com múltiplos métodos, como senhas ou redes sociais, além de proteger o acesso a recursos sensíveis, garantindo que apenas usuários autorizados possam interagir com o sistema.

Utilizaremos **Lambda** para gerenciamento de agenda, pesquisa de médicos, aceita e recusa de consultas e agendamento e cancelamento de consultas, pois oferece vantagens significativas sendo um serviço serverless que elimina a necessidade de gerenciar a infraestrutura, garantindo escalabilidade automática e reduzindo custos operacionais. Lambdas lidam bem com picos de tráfego, proporcionando baixa latência e uma experiência fluida ao usuário. Além disso, permitem implementar medidas de segurança robustas, como validação de tokens e verificação de permissões, garantindo a proteção dos dados.

Utilizamos o padrão **SAGA** para garantirmos a consistência dos dados. O padrão SAGA divide uma transação longa em várias transações menores que podem ser desfeitas (compensadas) de forma independente. Isso assegura que, mesmo em caso de falhas, o sistema possa voltar a um estado consistente.

O **Chime SDK** facilita a implementação de videochamadas e teleconsultas seguras e de alta qualidade. Ele oferece uma solução integrada para comunicação em tempo real, melhorando a interação entre médicos e pacientes de forma eficiente e escalável
que permite a implementação de áudio, vídeo e compartilhamento de tela em tempo real que faz sentindo para nosso projeto pensando no âmbito da TeleConsulta.

Utilizamos o **SNS** pois permite a comunicação assíncrona entre serviços, garantindo que os sistemas possam continuar operando independentemente do estado ou da carga dos outros serviços. Isso é crucial para manter a performance e a disponibilidade. Ele garante que as mensagens sejam entregues, mesmo em caso de falhas em alguns componentes do sistema.

Para gerenciar o fluxo de agendamento e cadastro, escolhemos o **DynamoDB** devido à sua natureza de banco de dados não relacional, permitindo armazenar objetos complexos contendo todas as agendas disponíveis e reservadas dos médicos, assim como informações de prontuários. 

Além disso, implementaremos um segundo banco de dados **RDS** para guardar as informações que foram notificadas, informações de prontuarios disponiveis e log das notificações

Para finalizar, todos os prontuários e receituarios serão armazenados de forma segura dentro de um **bucket S3**. O acesso aos prontuários será controlado por políticas de permissão rigorosas, garantindo que apenas médicos autorizados possam baixar os prontuários dos pacientes.

##  Fluxograma do Sistema - Médico
![image](https://github.com/user-attachments/assets/9761794e-c10d-4a92-a39e-b5d2ce818251)
![image](https://github.com/user-attachments/assets/8721f792-952c-465c-a057-8c39fd2d5736)
![image](https://github.com/user-attachments/assets/acc2abf1-a595-43b5-9fa9-9c9580610a8c)

##  Fluxograma do Sistema - Paciente
![image](https://github.com/user-attachments/assets/20aad976-fb06-402e-8510-386ac617aaf4)




## 👨‍💻 Integrantes
Edgar Santos,
Kauan Falcão,
Leandro Carvalho,
Rodolfo Azevedo,
Marcel Leme

@2024
