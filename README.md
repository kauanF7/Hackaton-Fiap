# Hackaton-Fiap

![image](https://github.com/user-attachments/assets/9e7e3ed5-658f-446b-bd24-aa554e95239b)

Contaremos com o **Amazon CloudFront** para garantir uma distribuição rápida e segura de conteúdo, melhorando significativamente a performance e reduzindo a latência globalmente. 

Utilizaremos um **Lambda** para autenticação de usuário pois oferece vantagens significativas. Pois sendo um serviço serverless, elimina a necessidade de gerenciar a infraestrutura, garantindo escalabilidade automática e reduzindo custos operacionais. Lambdas lidam bem com picos de tráfego, proporcionando baixa latência e uma experiência fluida ao usuário. Além disso, permitem implementar medidas de segurança robustas, como validação de tokens e verificação de permissões, garantindo a proteção dos dados.

Como parte da arquitetura, implementaremos um **API Gateway** para internalizar as requisições, encaminhando-as para um **Load Balancer** que distribui o tráfego entre os containers da API de forma balanceada. 

Optamos por **ECS Fargate** devido à facilidade de configuração e à rápida escalabilidade parametrizável. Inicialmente configuraremos duas tasks operando 24/7, com a capacidade de escalar até 15 tasks conforme necessário. Para escalar, definiremos métricas de CPU e memória para garantir um dimensionamento eficiente e adequado dos recursos do sistema. Essas métricas nos permitirão monitorar o uso dos recursos em tempo real e ajustar dinamicamente a capacidade conforme necessário, assegurando que tenhamos sempre o desempenho ideal e evitando sub ou super utilização dos recursos.

Para gerenciar o fluxo de agendamento e cadastro, escolhemos o **DynamoDB** devido à sua natureza de banco de dados não relacional, permitindo armazenar objetos complexos contendo todas as agendas disponíveis e reservadas dos médicos, assim como informações de prontuários. 

Além disso, implementaremos um segundo banco de dados **MySQL** para gerenciar os cadastros de usuários, aproveitando a facilidade de relacionamento entre tabelas e a alta performance em escalas maiores. Essas escolhas foram feitas com o objetivo de otimizar a eficiência operacional e a capacidade de resposta do sistema, garantindo uma experiência robusta e confiável para os usuários finais.

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
