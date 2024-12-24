# DrivingExamApp

A microservices-based online testing system using Message Broker and WinForms.

## System Architecture

### 1. Solution
#### Services Layer
- **QuestionService**
  - Question bank management
  - CRUD operations
  - Question categorization
  - Import/Export functionality

- **ExamService**
  - Exam creation and management
  - Automated grading
  - Results reporting

- **UserService**
  - Authentication and authorization
  - User profile management
  - Role-based access control

#### API Gateway
- Single entry point
- Load balancing
- Request routing
- Authentication/Authorization

#### Shared
- DTOs
- Common utilities
- Constants and configurations

### 2. Message Broker (RabbitMQ)
- Asynchronous service communication
- Event publishing/subscription
- Message queuing

### 3. Database
- Dockerized SQL Server
- Database per service
- Migration scripts

### 4. Frontend
- WinForms Application
- Material Design UI
- Responsive Layout

## Setup

### Prerequisites
- .NET 8.0 SDK
- Docker Desktop
- SQL Server Management Studio (SSMS)
- Visual Studio 2022

### Installation Steps
1. Clone repository
```bash
git clone https://github.com/username/project-name.git
```

2. Start Docker containers
```bash
docker-compose up -d
```

3. Run database migrations
```bash
dotnet ef database update
```

4. Build and run solution
```bash
dotnet build
dotnet run
```

## Contributing
1. Fork repository
2. Create feature branch
3. Commit changes
4. Push to branch
5. Create Pull Request

## License
Distributed under the MIT License. See `LICENSE` for more information.

## 📞 Contact

Nhat Cuong (CoderSaiya) - sonysam.contacts@gmail.com

Project link: [project repo](https://github.com/CoderSaiya/DrivingExamApp)
