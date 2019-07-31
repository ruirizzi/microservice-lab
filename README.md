# microservice-lab
>Lab repository to test microservices.
## Why?

I've created this repo as a laboratory to test how I could develop a simple microservice composed of a **WebApi**, a **WebServer** and a **Database**. All inside a **Docker** container.

The chosen technologies where [**.NET Core**](https://dotnet.microsoft.com/) as framework, [**nginx**](http://nginx.org/) as reverse proxy and [**MSSQL Server Linux**](https://hub.docker.com/_/microsoft-mssql-server) Docker image.

[**Docker**](https://www.docker.com/) was also used, obviously.
## Getting Started  
This small guide should help you run the Docker image and run tests.
### Build the Code
This WebAPI was developed in `ASPNet Core` so in order to build, publish and run tests, you must have `dotNet Core` installed on your environment. 
>Check out their [download page](https://dotnet.microsoft.com/download) and follow the installation instructions for your system.
>
After installing, open a terminal window and enter `dotnet --version` to check if the installation was successful:

![dotnet version command result](https://imgur.com/fCFooub.png)

Clone this repo and then:
```bash
dotnet restore
dotnet build
dotnet publish
```
This will allow you to correctly build the WebAPI.

### Runing the Docker Containers
In order to run the Docker image, you **must** have Docker installed in you [**Windows**](https://download.docker.com/win/stable/Docker%20for%20Windows%20Installer.exe), [**Linux**](https://docs.docker.com/install/linux/docker-ce/debian/) or [**Mac**](https://download.docker.com/mac/stable/Docker.dmg).
After installing Docker on your system and certifying that it is running, you should:
```bash
~\microservice-lab\docker volume create sqlserverdata 
~\microservice-lab\docker-compose build
~\microservice-lab\docker-compose up
```
The result should look like this:

![docker-compose up result](https://i.imgur.com/Ob1KlcP.png)

### Building and publishing in a single step
Alternatively to the aforementioned building steps, you can simply run one of the scripts on the project's root folder.

>Run the `bash` script `build.sh`

After that you can just `docker-compose up`

## Using
### Default Bank Accounts

By default, I've inserted 6 bank accounts to the database:

![bank accounts](https://imgur.com/3gYYuqA.png)

### Transfer Funds
You can `POST` to `localhost/api/bank` a fund transfer request and the API will try to place it, if the bank accounts have funds and/or are allowed to go overdraft (negative funds). The `body` should be:

![post body](https://imgur.com/4VD6ksf.png)

>If everything goes right, you should get a `200 OK` status message.

>If a given account number does not exists, you'll get a `404 Not Found` status message. 

>If the origin account doesn't allow overdraft (negative funds), you'll get a `400 Bad Request` status message.

### Checking entries

You can check an account entries (transaction history) by `GET` to `localhost/api/bank/GetEntriesByAccountId/{accountId}`; so, regarding the transfer mentioned above, making this request to the `AccountId` 2, will return:

![](https://imgur.com/Rx8J6o2.png)

And for the `AccountId` 1:

![](https://imgur.com/YG7mpYx.png)

## License

[![badge](https://img.shields.io/github/license/ruirizzi/microservice-lab)](https://github.com/ruirizzi/microservice-lab/blob/master/LICENSE)