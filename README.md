### <h2 align="center">  Welcome to the RabbitMQ Samples repository 👋 </h2>
### What is RabbitMQ ?
RabbitMQ is an open-source message broker software used for sending, receiving, and managing messages between different components of a system. 
RabbitMQ is based on the Advanced Message Queuing Protocol (AMQP) and provides a secure and efficient way to send messages between applications.

### Key Features of RabbitMQ :
- **Reliability** : Supports message durability, delivery acknowledgments, and publisher confirms.
- **Flexible Routing** : Messages can be routed through exchanges before reaching queues.
- **Clustering** : Can be clustered across multiple nodes to ensure high availability.
- **Management UI** : Provides a web-based UI for managing and monitoring RabbitMQ.

### About This Repository :
This repository showcases two fundamental messaging patterns using RabbitMQ :
- **Worker Pattern** : Distribute heavy tasks across multiple worker processes for efficient load balancing.
- **Pub/Sub Pattern** : Broadcast messages to multiple subscribers simultaneously for effective event distribution.

### Project Structure :
Core : Contains shared code and utilities that are used across multiple projects.
<br/>
Worker : Contains the projects for the Worker pattern example.
<br/>
PubSub : Contains the projects for the Pub/Sub pattern example.
