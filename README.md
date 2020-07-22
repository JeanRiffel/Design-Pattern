# Design Pattern in C#

This repository is part of my studies approaching desing patterns.

# Source of content

- I took the course called design-patterns-in-csharp-and-dotnet from udemy
  Link to the course is here https://www.udemy.com/course/design-patterns-csharp-dotnet/
  
  
# What does really Desing Patterns means?
  
  Placing in simple words Desing Patterns means that we have repeatable solution to a common bunch of problems from software development. We could say there  are three important branches which we can use for applying Desing Patterns.
  
  
  ## There are the follows:
  
  ### Creational Patterns: These design patterns are all about instantiation, so we have on this topic:
  
   #### - Abstract Factory:
      
      * Create a family of objects which share a common interface;
      * Delegate the instantiation to another object;
      * Use composition;
     
   #### - Factory Method:
     
      * Use inheritance to decide the object to be instantiated;
      * Dependens on inheritance;
     
   #### - Builder:
   
      * Build a single type of objects;
      * Is tipically used when the object creation is more complex than just calling a constructor;
           
   #### - Prototype:
   
      * This pattern is used to duplicate or clone objects when is important to enhance performance for dealing with complexity or costly.
      * In short terms when the developer has to deal with complex objects is possible to use this pattern.
     
   #### - Singleton:
   
      * Creates a single tupe of objects;
      * Ensure that a class has just a single instance;
      * Provide a global access point to that instance;
    
  ### Behavioral Patterns
  
  Still studying ... please wait :)
  
  ### Structural Patterns
  
  In short some of these structural patterns are working with composition.


   ### - Bridge:  

      * This pattern allow us to develop classes idependently from each others and in the end put them to work together.
      * Usually the classes are being developed.

   ### - Adapter

      * Usually the classes was already implemented and now the developer want to place different classes to working together. 
      * Tries to make the existing interface usable.
      * Usually wraps only one object
      * Is useful when the developer has a existing class however the existing interface is not compatible with the rest of the code or the legacy code has to     communicate with the system as well. 

   ### - Facade 

      * This pattern provides a simplified interface to a library.
      * Defines a new inteface for a existing objects
      * Works with a entire subsytem of objects. 


