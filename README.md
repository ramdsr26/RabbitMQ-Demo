# RabbitMQ-Demo
This project explain about how rabbitmq can be used in .Net

What is RabbitMQ?
RabbitMQ is open source message broker software (sometimes called message-oriented middleware) that implements the Advanced Message Queuing Protocol (AMQP). The RabbitMQ server is written in the Erlang programming language and is built on the Open Telecom Platform framework for clustering and failover. Client libraries to interface with the broker are available for all major programming languages.

<img width="253" height="53" alt="image" src="https://github.com/user-attachments/assets/56f1e3fe-e1f2-48aa-88f9-766f40d06680" />

# How to use this image

# Running the daemon

One of the important things to note about RabbitMQ is that it stores data based on what it calls the "Node Name", which defaults to the hostname. What this means for usage in Docker is that we should specify -h/--hostname explicitly for each daemon so that we don't get a random hostname and can keep track of our data:

Need docker desktop to run locally [ install and run the below command ]
```
docker run -d --hostname my-rabbit --name some-rabbit -p 5672:5672 -p 15672:15672 -e RABBITMQ_DEFAULT_USER=guest -e RABBITMQ_DEFAULT_PASS=guest rabbitmq:3-management
```
open http://localhost:15672/ in browser using guest/guest credentials

<img width="1751" height="998" alt="image" src="https://github.com/user-attachments/assets/41f5a385-2451-4a63-ad28-c601717022f0" />

# Open the Solution and run  producer and consumer application.

<img width="1910" height="1031" alt="image" src="https://github.com/user-attachments/assets/47328282-7b5c-45d4-8d23-17c098379a68" />

# console output
<img width="1114" height="603" alt="image" src="https://github.com/user-attachments/assets/f28025dd-3e44-4861-ba9c-32235b325418" />
