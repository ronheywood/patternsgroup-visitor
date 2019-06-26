

> Q1: What are the disadvantages of using inheritance to provide Duck behavior?

Considering the implementation of the behaviour via an Interface Flyable / Quackable - we again see the issue with duplicate code - implementing this behaviour for many instances (48 is the number cited in the book) would make change very complicated.

> Q2: Lots of things can drive change. Consider of the reasons code changes.

> DESIGN PRINCIPLE:
Identify the aspects of your application that vary and separate them from what stays the same.

This principle makes for fewer unintended consequences from code changes and more flexibility in systems.

## Applying the pattern
Given that the flying and quacking behaviours are the things that vary - how can we extract these into their own classes and make use of them in the implementations?

> DESIGN PRINCIPLE:
Program to an interface, not an implementation.
```
  <interface>
  FlyBehaviour
  + Fly()
```
```
FlyWithWings : FlyBehaviour
+ Fly() { 
    // implements duck flying behaviour
}
```
```
 Flightless : FlyBehaviour
 + Fly() {
     // do nothing - can't fly
 }
```

> Q3: Could you add motor powered flying behavior to the Rubber duck?

> Q4 Can you think of a class that might want to use the Quack behavior that isn’t a duck?

## How do we integrate this?

Add instance variables to hold the behaviour class, 
and call their methods from within an action method on the Duck super class - eg: 
+ performFly() 
+ performQuack()

```
public void performFly()
{
    _flyingBehaviour.Fly();
}
```

> Q5: What techniques can we use to make these behaviours available to the class implementing them?

## "Is a" vs "Has A"

Relationships between classes are important when designing for change.

> DESIGN PRINCIPLE:
Favor composition over inheritance.

Each duck "Has A" flying behaviour - this is an example of Composition vs Inheritance. It can also be thought of as Encapsulation. These make up two of the four principles of object-oriented programming.

## What about Polymorphism

“Program to an interface” really means “Program to a supertype.”

The point is to exploit polymorphism by programming to a supertype, so that the actual runtime object isn’t locked into the code.

And we could rephrase “program to a supertype” as 

> “The declared type of a variable should be a supertype, usually an abstract class or interface! 

Objects assigned to variables can be of any concrete implementation of the abstract class.

Do you remember the Factory Method?