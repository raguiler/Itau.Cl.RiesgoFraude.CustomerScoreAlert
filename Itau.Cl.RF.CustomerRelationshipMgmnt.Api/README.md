## Itau.Cl.{ProjectName}.{Bff}.{TemplateServerless}

#### Ejemplo de implementaci�n de aplicaci�n contenerizada compatible para despliegue sobre Local, ECS, EKS y Lambda Serverless.

Proyecto de ejemplo de aplicaci�n que puede ser usada como referencia para implementar microservicios BCL y BFF. Ha sido desarrollada con .net 6 y c# 9, y se habilitan 
las siguientes capacidades base:

1. Documentaci�n Code First to OpenAPI. Usando Swashbuckle.AspNetCore
2. HttpClient para invocaci�n de APIs de API Connect. 
3. Hosting sobre AWS Serverless Lambda. Amazon.Lambda.AspNetCoreServer.Hosting. https://aws.amazon.com/blogs/compute/introducing-the-net-6-runtime-for-aws-lambda/


Compilaci�n y Hosting:

El proyecto incluye un DockerFile que permite compilar un container image sobre linux (https://mcr.microsoft.com/v2/dotnet/aspnet/tags/list). Que puede ser hosteado 
localmente con docker, Kubernetes, EKS o Lambda Serverless as Container.

---

Lambda Hosting.

Lambda requiere un handler para levantar la aplicaci�n, en nuestra arquitectura las exposiciones son a traves de Api Gateway de API Connect. Para disponibilizar las APIs 
del controller, se usa el ApplicationLoadBalancer Handler, que es configurado usando "builder.Services.AddAWSLambdaHosting(LambdaEventSource.ApplicationLoadBalancer)" al iniciar la aplicaci�n. 

Configuraci�n de Hostin en AWS Console.

Para configurar correctamente la aplicacion, luego de crear el Lambda y usar la imagen cargada previamente en ECR, se debe configurar el valor de CMD (https://docs.aws.amazon.com/lambda/latest/dg/configuration-images.html?icmpid=docs_lambda_help), con el nombre del Assembly de la aplicaci�n, por ejemplo "Itau.Cl.ProjectName.Bff.TemplateLambda.dll".

Done! Con esto, tendremos nuestra aplicaci�n hosteada como Serverless en AWS Lambda.