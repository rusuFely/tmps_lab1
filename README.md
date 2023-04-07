# tmps_lab1

S – Single Responsibility Principle – o clasa sau o metoda trebuie sa aiba o singura responsabilitate, o singura cauza, un singur motiv de a fi schimbat. 
Clasa sau metoda trebuie sa fie responsabila de un singur lucru. Fara single responsibility codul devine mai fragil si mai rigid. Utilizand acest principiu noi 
reducem complexitatea acestui cod – avem diferite clase, metode care au logica separata, codul devine mai Putin cu plad (are multe dependente), creste citibilitatea 
codului, mentenanta si extinderea lui, putine erori si codul devine mai usor testabil.

O – Open Closed Principle – un modul sau o clasa trebuie sa fie deschisa pentru extindere, dar inchisa pentru modificari. 

L – Liskov Substition Principle – obiectul unei clase trebuie sa fie inlocuit cu obiecte a subclasei fara ca sa strice aplicatia. 
Sublasa trebuie sa substituie clasa de baza. Subclasele trebuie sa aiba comportamente diferite fata de parintele sau sa nu aiba careva metode nedefinite.

I – Interface Segregation Principle – un client sau un modul nu trebuie sa fie fortat sa depinda de interfetele sau metodele pe care el nu le utilizeaza.
Impartirea interfetelor mai mari in mai multe interfere mici pentru a ne usura lucrul si de a evita metode neimplementate.

D – Dependency Inversion Principle – modulele de un nivel mai inapt nu trebuie sa depinda de module de un nivel mai in jos, ele trebuie sa depends de abstractie. 
Detaliile, implementarile trebuie sa depinda de ceva abstract.
