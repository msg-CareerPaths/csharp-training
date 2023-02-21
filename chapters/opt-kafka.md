## Kafka

Apache Kafka is an open-source distributed streaming platform that was initially developed by LinkedIn and later became part of the Apache Software Foundation. Kafka provides a high-throughput, low-latency, fault-tolerant messaging system that can be used for building real-time data pipelines, streaming applications, and event-driven architectures.
Kafka is a publish-subscribe messaging system that allows producers to publish data to a set of topics, and consumers to subscribe to one or more topics to receive the data. 
Kafka's architecture is based on the following key components:
 - Topics: A topic is a category or stream of messages. Producers publish data to a topic, and consumers subscribe to a topic to receive the data.
 - Producers: Producers are the components that write data to Kafka. They can be any application that generates data, such as a web server, sensor, or log file.
 - Consumers: Consumers are the components that read data from Kafka. They can be any application that processes data, such as a database, analytics engine, or dashboard.
 - Brokers: Brokers are the servers that store and manage the data. They are responsible for receiving data from producers, storing the data in a distributed manner, and serving the data to consumers.
 - Partitions: A partition is a unit of data in Kafka. Each partition is a sequence of records, and the records within a partition are ordered by their offset.

Kafka is used to build real-time data pipelines, including companies such as LinkedIn, Uber, and Netflix. 
Some of the common use cases for Kafka include: stream processing, data integration, message queuing and log aggregation.

**Further Resources:**

 - [Kafka in 100 Seconds](https://www.youtube.com/watch?v=uvb00oaa3k8)
 - [Kafka .NET Client](https://docs.confluent.io/kafka-clients/dotnet/current/overview.html#ak-dotnet)
 - [Kafka official site](https://kafka.apache.org/documentation/#introduction)
