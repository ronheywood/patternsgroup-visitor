# Strategy Pattern - Duck Simulator

Duck Simulator is an example project given in the book [Head First Design Patterns](https://www.oreilly.com/library/view/head-first-design/0596007124/ch01.html) 
by Kathy Sierra, Bert Bates, Elisabeth Robson, Eric Freeman

To aid disucssion of the Strategy Pattern in study groups, we can follow the process according to the following steps.

 DuckSimulator implements many varients of the Duck superclass
```
 AS a Vendor
 SO THAT DuckSimulator offers a more realistic experience
 I WANT to be able to commannd the ducks to Fly

 GIVEN a set of simulation Ducks
 WHEN the user issues the FLY command
 THEN the ducks should all start flying
```

In the example given in the book, we see that adding the localised Fly method to the Duck superclass results in a "nonlocal side effect" - Flying rubber Ducks.

We are prompted to consider that simply overriding the Fly method is not ideal - since we would duplicate code across many sub classes. (A decoy duck should neither fly nor quack)