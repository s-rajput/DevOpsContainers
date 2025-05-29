# DevOps Containers

## Overview

**DevOps Containers** is a demonstration repository showcasing best practices for building, testing, containerizing, and deploying .NET applications using modern DevOps workflows. This project leverages Azure DevOps CI/CD pipelines to automate the entire lifecycle—from code build and testing to Docker image creation, registry management, and deployment to Azure. The repository also includes Entity Framework migrations, API documentation via Swagger, and security enhancements.

---

## Features

- **Automated CI/CD Pipelines:**  
  End-to-end automation using Azure DevOps for building, testing, containerizing, and deploying applications.

- **Docker Containerization:**  
  Application is packaged into Docker containers for consistency across environments.

- **Docker Registry Integration:**  
  Built images are pushed to a Docker registry (Azure Container Registry or Docker Hub).

- **Azure Deployment:**  
  Automated deployment of containers to Azure services (e.g., Azure App Service or Azure Kubernetes Service).

- **Entity Framework Migrations:**  
  Database schema is managed using EF Core migrations, including initial schema creation and index addition.

- **API Documentation with Swagger:**  
  Integrated Swagger/OpenAPI documentation for easy API exploration and testing.

- **Security Hardening:**  
  Removes the `Server` header from API responses to reduce information exposure.

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Docker](https://www.docker.com/products/docker-desktop)
- [Azure CLI](https://docs.microsoft.com/en-us/cli/azure/install-azure-cli) (for manual Azure interactions)
- Azure DevOps account (for CI/CD pipelines)
- Access to a Docker registry (Azure Container Registry or Docker Hub)

### Setup & Usage

1. **Clone the Repository**
    ```
    git clone https://github.com/s-rajput/DevOpsContainers.git
    cd DevOpsContainers
    ```

2. **Build the Application Locally**
    ```
    dotnet build
    ```

3. **Run Tests**
    ```
    dotnet test
    ```

4. **Run Entity Framework Migrations**
    ```
    dotnet ef database update
    ```

5. **Build and Run Docker Container Locally**
    ```
    docker build -t devopscontainers:latest .
    docker run -p 8080:80 devopscontainers:latest
    ```

6. **Access API Documentation**
    - Visit `http://localhost:8080/swagger` in your browser after running the container.

---

## CI/CD with Azure DevOps

The repository includes sample Azure DevOps pipeline YAML files to automate:

- Building and testing the application
- Creating and pushing Docker images to a registry
- Running EF Core migrations
- Deploying containers to Azure

**To use:**
- Import the pipeline YAML into your Azure DevOps project.
- Set up required pipeline secrets (e.g., registry credentials, Azure service connection).
- Trigger the pipeline on code commits or pull requests.

---

## Security Considerations

- The API removes the `Server` header from responses to minimize information leakage.
- Store secrets and credentials in Azure DevOps Pipeline secrets or Azure Key Vault.
- Regularly update dependencies and base images to patch vulnerabilities.

---

## Contributing

Contributions are welcome! Please open issues or submit pull requests for improvements, bug fixes, or new features.

---

## License

This project is licensed under the [MIT License](LICENSE).

---

## Acknowledgements

- [Azure DevOps](https://azure.microsoft.com/en-us/services/devops/)
- [Docker](https://www.docker.com/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Swagger / Swashbuckle](https://github.com/domaindrivendev/Swashbuckle.AspNetCore)

---
## Demo :wave:

![](https://github.com/s-rajput/DevOpsContainers/blob/master/files/one.gif?raw=true)

![](https://github.com/s-rajput/DevOpsContainers/blob/master/files/two.gif?raw=true)
 
![](https://github.com/s-rajput/DevOpsContainers/blob/master/files/swagger.jpg)
  
![](https://github.com/s-rajput/DevOpsContainers/blob/master/files/azuredevops.jpg)

---
## Contact

For questions or support, please open an issue in this repository.



