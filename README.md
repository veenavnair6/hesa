**Classes**

- An abstract class Bee is added to be inherited by othery Bee type classes
- Chose abstract class instead of interface so that method implementations could be shared.
- Health property's set section is set as private so that it is not accessible from outside of the class and only be manipulated using Bee class methods.
- Death is a boolean variable that denotes the death status 
- DeathFactor is the death threshold for each bee type and is an abstract member in the Bee class
- Each bee type implements its own death factor

**Application**

- Added a windows form to display the bee and its health
- Added a button to call the damage function of bee class.
