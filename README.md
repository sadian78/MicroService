first commit => use docker and instal package MongoDb.Driver and install mongoDb on 27017 port on docher 
if you want use images docker you can go hub.docker.com and you can see another instances for docker but i use (docker pull mongo)=>instal mongo db
for how use => you can read how use in hub.docker website 
command for run mongo image:
1.docker pull mongo
2.docker run -d -p 27017:27017 --name (name-your-instance) mongo
3.docker ps (you can see your images)
4.docker exec -it (name-your-instance) (address(/bin/bash)) => you can execute image ofcourse you can directly from app docker
5.mongosh
6.show dbs => you can see databases
7.....
after doing settings docker you should connect databse from your project =>create entities,setup connctionSettings in appsettings.json , create IContext interface and Context class
