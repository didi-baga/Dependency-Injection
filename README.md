# Dependency  Injection

## Overview

Collection of projects to play with, Use to explore and gain an understanding of the Dependency Injection principle using C#.

## Case of Study

The goal is to explore the following:

- Service lifetimes
- Explicit Dependency
- Isolation
- Performance

For each topic, a new project will be provided and all of them will use **Sample Classes**.

## Sample Classes

Sample Classes contain Interfaces and dependent classes to simulate various cases.
**Note:** Sleep timer will simulate time-consuming operations.

Class list and short description:

* **Configuration**
    * IConfiguration - interface for configuration class 
    * Configuration - Implements *IConfiguration*
* **GlobalLogic**
    * IAdmin - interface for configuration change 
    * SampleAdmin - Implements *IAdmin*. Set Globally (Singletone) available *Configuration*
* **Infrastructure**
    * IConnection - interface for communication 
    * TCPConnection - Implements *IConnection*. Imitates TCP/IP Connection. In time-consuming operations Sleep timer is used. 
* **Logic** 
    * ICustomer - Interface for customer class. All Derived classes depend on **Sub Logic** classes. 
    * CorporateCustomer - Implements *ICustomer*. Imitates Corporate Customer. In time-consuming operations Sleep timer is used. 
    * LegalCustomer - Implements *ICustomer*. Imitates Legal Customer. In time-consuming operations Sleep timer is used. 
    * RetailCustomer - Implements *ICustomer*. Imitates Retail Customer.
    * **SubLogic**
        * IRateCalculator - interface for business Logic.
        * RateCalculatorExtended - Implements *IRateCalculator*, uses IConnection to communicate with service. In time-consuming operations Sleep timer is used. 
        * RateCalculatorStandard - Implements *IRateCalculator*, uses IConnection to communicate with service.

**Class Dependencies:** 
 * CorporateCustomer, LegalCustomer, and RetailCustomer require 
    * IRateCalculator and IConfiguration interface objects
* RateCalculatorExtended and RateCalculatorStandard require
    * IConnection interface objects
* SampleAdmin require
    * IConfiguration  interface objects

## Implementation 

### Service lifetimes

**Dependency Injection** and **Dependency Injection No Container** projects can be used to experiment with *service lifetime*
    
### Explicit Dependency

**Explicit Dependency** project can be used to explore the Explicit Dependencies Principle 

### Isolation

**Isolation No Container** and **Isolation** projects can be used to explore what kind of side effects can have on singleton objects.  

### Performance

**Performance No Container**, **Performance** and **Execution Time Calculator** project can provide performance information.
    
