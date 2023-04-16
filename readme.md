# Todo

Todo is a .net6 project for todo list . this project was prepared according to google api standards

## Installation

### Docker

Using DockerHub 

https://hub.docker.com/repository/docker/pixellence/dotnetapi/general 

for image 
```bash
docker pull pixellence/dotnetapi:latest
```
for image run
First you need to add some mongodb configuration.

```bash
 docker run -p 80:80 --env Collection_Name=<CollectionName> --env Connection_String=<ConnectionString --env Database_Name=<DatabaseName>  pixellence/todoapi
```
or 

you can added to dockerfile this configure

ENV Collection_Name=<CollectionName>
ENV Connection_String=<ConnectionString>
ENV Database_Name=<DatabaseName>

## Usage

after that
You can test with this url

http://127.0.0.1/api/Todo  

## Contributing

Pull requests are welcome. For major changes, please open an issue first
to discuss what you would like to change.

Please make sure to update tests as appropriate.

## License

[MIT](https://choosealicense.com/licenses/mit/)