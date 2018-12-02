(Note: l'activité suivant ce TP consiste à refactoriser celui-ci)

Instructions du TP :

"TP : Créez un petit jeu orienté objet
Dans ce TP, nous allons essayer de mettre en pratique ce que nous avons appris en programmation orientée objet avec le C#.

Avec ce TP, vous aurez l'occasion de vous entraîner à créer des classes, à manipuler l’héritage, à créer des propriétés, à encapsuler, à substituer des méthodes, à jouer avec le polymorphisme et vous pourrez vous confronter à des situations un peu différentes de la théorie !

Le but du TP est de créer un mini jeu où nous allons pouvoir utiliser un dé pour tuer des monstres, super original ! Bon, tout va être automatique et aléatoire, on est pas là pour faire un jeu complet avec des interactions avec l'utilisateur ; on est là pour s'entrainer à faire de l'OO ;) .
Quoique ... si vous avez envie d'aller plus loin, libre à vous :).

Instructions pour réaliser le TP
Alors voici l'énoncé du TP. Vous allez devoir créer 4 classes :

Une classe Joueur, représentant notre héros.

Une classe MonstreFacile.

Une classe MonstreDifficile, qui bien sûr va hériter des fonctionnalités d'un monstre facile et qui en ajoutera.

Une classe De pour gérer notre tirage aléatoire, comme un dé classique.

Les règles de mon cru qui suivent peuvent paraître compliquées mais en fait elles sont assez facile à retranscrire en code, donc ne vous découragez pas à la lecture de celles-ci et revenez-y une à une.

Le principe est de voir combien notre héros va pouvoir tuer de monstres faciles et de monstres difficiles avant de mourir, en ayant perdu tous ses points de vie (mon héros démarre avec 150 points de vie). Chaque monstre facile tué rapporte 1 point, chaque monstre difficile tué en rapporte 2.
Un monstre aléatoire arrive, le héros attaque le monstre ; puis si le monstre a survécu il attaque à son tour le héros et ceci jusqu'à ce que mort s'en suive.

Une attaque du héros sur un monstre consiste en un jet de dé des deux protagonistes. Si le dé du héros est supérieur ou égal au dé du monstre, alors celui-ci est vaincu. Sinon, rien ne se passe et c'est au tour du monstre d'attaquer.
L'attaque du monstre facile sur le héros est similaire, mais à la différence que le jet du monstre doit être strictement supérieur au jet du héros. Eh oui, il faut bien avantager un peu notre héros :).

A noter que lorsque le héros subit des dégâts, son bouclier se déclenche avec un nouveau jet de dé. Si ce dernier est inférieur ou égal à 2 (donc 2 chances sur 6), alors le héros ne perçoit pas de dégâts. Le cas contraire, ses points de vie sont diminués d'une valeur forfaitaire, disons 10 points de vie.

L'attaque du monstre difficile est la même que celle du monstre facile, sauf qu'il enchaine avec un sort magique. Un jet de dé est réalisé et si ce jet est différent de 6 alors le héros perçoit des dommages équivalent à la valeur du dé multiplié par une valeur forfaitaire, disons 5.

N'oubliez pas, pour générer un nombre aléatoire, il faut instancier un objet Random et appeler la méthode Next sur l'objet. On lui passera en paramètre les bornes du tirage aléatoire. Par exemple pour avoir un nombre aléatoire entre 1 et 6 (inclus), il faut faire :

Random random = new Random();
int tirage = random.Next(1, 7);
N'hésitez pas à conserver l'objet random comme membre des classes, pour éviter d'avoir à le réinstancier à chaque tirage.

Au niveau des détails techniques des classes :

La classe Joueur  :

possède une propriété en lecture seule qui contient les points de vies ; ceux-ci sont initialisés dans le constructeur.

possède une propriété en lecture seule permettant de savoir si le joueur est vivant, et encapsule le nombre de points de vie.

possède une méthode Attaque, prenant en paramètre un monstre

possède une méthode SubitDegats qui prend en paramètre un entier avec la valeur des dégâts subits

 

La classe MonstreFacile  :

possède également une méthode Attaque   

possède une propriété en lecture seule qui encapsule le fait de savoir si le monstre est vivant

La classe MonstreDifficile  :

modifie le comportement de la méthode Attaque 

La classe De  :

possède une méthode LanceLeDe qui renvoie un entier

Et voilà, vous savez tout. Bon, ça a l'air long comme ça, mais en fait ce n’est pas si compliqué, sauf si bien sûr vous n’avez pas lu ou pas compris les chapitres précédents. Dans ce cas, n’hésitez pas à y rejeter un coup d’œil.

En résultat de mon côté, j'ai obtenu :

Snif, vous êtes mort...
Bravo !!! Vous avez tué 8 monstres faciles et 10 monstres difficiles. Vous avez 28 points.
Bien sûr, vous pouvez vous rajouter des méthodes privées, des variables membres (comme un objet Random), et ce que vous voulez d'autre. :)"