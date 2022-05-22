# Docker workshop opdrachten

### Opdracht 1
In deze opdracht gaan we een dockerfile maken en we gaan een .net core applicatie hosten in een container.
Voer onderstaande commando’s uit in een terminal bijv. een cmd venster een powershell console of in de console van visualstudio code
 
Clone de repo voor de dockerworkshop demo app
git clone https://github.com/marcoippel/DockerWorkshop-Demo-app.git

 
Ga naar het pad waar de projectfile staat
cd “.\DockerWorkshop-Demo-app\DockerWorkshop Demo app\”

 
Start Visual Studio Code
code .

 
Open de docker file in VS Code
Gebruik als basis image: mcr.microsoft.com/dotnet/aspnet:3.1
kopieer de bestanden welke gepubliceerd zijn in de folder '/bin/Release/netcoreapp3.1/publish/' app naar de folder /app in het image.
Gebruik de assembly “DockerWorkshop Demo app.dll” als entrypoint.
Build het image en tag het image met de tag “demoapp”
Start de container met als argument: “Hello-world”


Opdracht 2
In deze opdracht gaan we het image wat we in het eerst scenario gemaakt hebben pushen naar dockerhub

Maak een repository aan in je dockerhub account
Login op dockerhub met je credentials in de terminal.
Tag je zojuist gebuilde image (demoapp) met de juiste tag incl. versie
Push het image naar de container registry

Opdracht 3
In deze opdracht gaan we de dockerstudy container starten welke verschillende opdrachten bevat. 
Open een powershell terminal en voer daar de volgende commando’s uit:
Invoke-WebRequest -URI https://raw.githubusercontent.com/marcoippel/playwithdocker-course/master/docker-compose.yml -OutFile docker-compose.yml


docker-compose up -d


Open in een browser de url http://localhost.

Als je klaar bent wil je dan het feedback formulier invullen


Handige docker commando's
docker ps (bekijk de containers)
docker network ls (bekijk de netwerken)
docker rm -f %containername% (verwijder een container op basis van naam)

