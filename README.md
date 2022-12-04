# Dependency  Injection

## Overview

Collection of projects to play with, Use to explore and gain understanding of Dependency Injection principle using C#.

## Case of Study

Goal is to explore:

- Service lifetimes
- Explicit Dependency
- Isolation
- Performance

For each topic new project will be provided and all of them will use **Sample Classes**.

## Sample Classes

Contains Interfaces and dependent classes to simulate various cases.
**Note:** Sleep timer will be used to simulate time consuming operations.

Class list and short description:

* **Configuration**
    * IConfiguration - interface for configuration class 
    * Configuration - Implements *IConfiguration*
* **GlobalLogic**
    * IAdmin - interface for configuration change 
    * SampleAdmin - Implements *IAdmin*. Set Globaly (Singletone) avaliable *Configuration*
* **Infrastructure**
    * IConnection - interface for communication 
    * TCPConnection - Implements *IConnection*. Imitates TCP/IP Connection. In time consuming operations Sleep timer is used. 
* **Logic** 
    * ICustomer - Interface for customer class. All Derived classes depend on **Sub Logic** classes. 
    * CorporateCustomer - Implements *ICustomer*. Imitates Corporate Customer. In time consuming operations Sleep timer is used. 
    * LegalCustomer - Implements *ICustomer*. Imitates Legal Customer. In time consuming operations Sleep timer is used. 
    * RetailCustomer - Implements *ICustomer*. Imitates Retail Customer.
    * **SubLogic**
        * IRateCalculator - interface for busness Logic.
        * RateCalculatorExtended - Implements *IRateCalculator*, uses IConnection to communicate with service. In time consuming operations Sleep timer is used. 
        * RateCalculatorStandard - Implements *IRateCalculator*, uses IConnection to communicate with service.

**Class Dependencies:** 
 * CorporateCustomer, LegalCustomer and RetailCustomer requre 
    * IRateCalculator and IConfiguration interface objects
* RateCalculatorExtended and RateCalculatorStandard requre
    * IConnection interface objects
* SampleAdmin requre
    * IConfiguration  interface objects

## Implementation 

### Service lifetimes

**Dependency  Injection** and **Dependency  Injection No Container** projects can be used to experiment whit *service lifetime* 
    
### Explicit Dependency

**Explicit Dependency** project can be used to explore Explicit Dependencies Principle 

### Isolation

**Isolation No Container** and **Isolation** projects can be used to what kind of side effect can have singleton object. 

### Performance

**Performance No Container**, **Performance** and **Execution Time Calculator** projects whill provide performance information. 
    
