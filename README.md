# AIoefentoets
Opdracht: Bibliotheek Management Systeem
Beschrijving
Je gaat een eenvoudig bibliotheek management systeem maken waarin verschillende soorten media (zoals boeken en tijdschriften) kunnen worden beheerd. Het systeem moet gebruik maken van interfaces en design patterns om de structuur flexibel en uitbreidbaar te maken.

UML-Diagram
plaintext
Code kopiëren
  +---------------------+
  |    IMediaItem       |<-----------------------------+
  +---------------------+                              |
  | +string Title       |                              |
  | +string Author      |                              |
  | +void DisplayInfo() |                              |
  +---------------------+                              |
             ^                                        |
             |                                        |
  +----------+-----------+                            |
  |                      |                            |
+---------------+     +--------------+                |
|    Book       |     | Magazine     |                |
+---------------+     +--------------+                |
| +int ISBN     |     | +int IssueNo |                |
+---------------+     +--------------+                |
| +void DisplayInfo() | +void DisplayInfo()           |
+---------------+     +--------------+                |
                                                      |
  +---------------------+                             |
  |   MediaFactory      |                             |
  +---------------------+                             |
  | +IMediaItem CreateMedia(string type, string title,| 
  |   string author, int identifier)                 |
  +---------------------+                             |
                                                      |
                                                      |
  +-----------------------------------------+         |
  |          LibraryManagement              |         |
  +-----------------------------------------+         |
  | -List<IMediaItem> mediaItems            |         |
  +-----------------------------------------+         |
  | +void AddMedia(IMediaItem media)        |         |
  | +void DisplayAllMedia()                 |         |
  +-----------------------------------------+
Vereisten
Interface (IMediaItem):

Eigenschappen: Title, Author
Methode: DisplayInfo()
Klassen (Book en Magazine):

Book: Eigenschap ISBN
Magazine: Eigenschap IssueNo
Beide klassen implementeren de DisplayInfo() methode die hun specifieke informatie weergeeft.
Factory Pattern (MediaFactory):

Methode CreateMedia die een nieuw IMediaItem object (Book of Magazine) creëert op basis van een type parameter.
Library Management System (LibraryManagement):

Bevat een lijst van IMediaItem objecten.
Methoden AddMedia om een nieuw media item toe te voegen en DisplayAllMedia om informatie van alle media items weer te geven.
Implementatie
Definieer de interface IMediaItem.
Implementeer de klassen Book en Magazine die de IMediaItem interface implementeren.
Implementeer de MediaFactory klasse met de CreateMedia methode.
Implementeer de LibraryManagement klasse met methoden om media items toe te voegen en weer te geven.

Tips:

Begin met het maken van een gedetailleerd UML-ontwerp voordat je met het coderen begint.
Gebruik een geschikte IDE (Integrated Development Environment) met UML-ondersteuning.
Test je code grondig om bugs te voorkomen.
Documenteer je code met behulp van opmerkingen en commentaar.
