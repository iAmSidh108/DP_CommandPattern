# **Command Pattern in Unity:**

## **What is the Command Pattern?**

The Command Pattern is a behavioral design pattern that transforms requests into objects, allowing parameterization of clients with different requests, queuing of requests, and logging of the requests. It encapsulates a request as an object, thereby allowing for parameterization of clients with different requests, queuing of requests, and the ability to support undoable operations.

![command-en](https://github.com/iAmSidh108/DP_CommandPattern/assets/63715240/10428dc8-8d3e-4632-a87e-b7b9796cccca)

## **Examples of using the Command Pattern in game development:**

   Think of it as a chef who works in a resturant and recieves several orders and all of those are queued and are performed one after another in a turn based manner.
   
   ![command-comic-1](https://github.com/iAmSidh108/DP_CommandPattern/assets/63715240/a79266b0-a5ae-4ade-a96d-5a7d6078180c)

1. **Player Input Handling:**
   - **Commands:** JumpCommand, AttackCommand.
   - **Invoker:** Input manager that triggers commands based on player input.
   - **Receiver:** Player character that executes the commands.

2. **Undo/Redo System:**
   - **Commands:** PerformActionCommand, UndoActionCommand.
   - **Invoker:** Undo manager that manages the execution and reversal of commands.
   - **Receiver:** Game systems affected by the commands.

## **Drawbacks of using Command Pattern:**

1. **Increased Complexity:**
   - The Command Pattern may introduce additional classes and complexity, especially for simple systems.

2. **Overhead:**
   - In scenarios where direct method calls could suffice, introducing command objects might add unnecessary overhead.

3. **Learning Curve:**
   - Developers unfamiliar with the pattern may find it challenging to understand and implement, especially in smaller projects.

## **How to implement Command Pattern:**

1. **Identify Commands:**
   - Determine the commands that need to be executed as distinct objects.

2. **Create Command Interface:**
   - Establish a common interface for all command classes, typically including an `Execute` method.

3. **Implement Concrete Commands:**
   - Create classes that implement the command interface, encapsulating the specific actions to be performed.

4. **Invoker Setup:**
   - Implement an invoker that triggers the execution of commands, often in response to user input or other events.

5. **Receiver Setup:**
   - Identify the objects that will execute the commands and ensure they can receive and execute the command objects.

6. **Optional Undo/Redo:**
   - If needed, implement the ability to undo or redo commands by creating corresponding undo command classes.

7. **Use Unity's Command Classes:**
   - Unity provides command-like classes in the form of `UnityEvent` or `Delegate` implementations, which can be used as a simplified form of the Command Pattern.

8. **Documentation:**
   - Clearly document the purpose and usage of each command, making it easier for developers to understand and maintain the system.

Implementing the Command Pattern in Unity can provide a flexible and extensible way to manage user input, game actions, and undo/redo functionality, especially in projects where command execution needs to be decoupled from the triggering events.

## How I implemented this pattern in this project?
   In process, will update soon.
   
![icegif-653](https://github.com/iAmSidh108/DP_CommandPattern/assets/63715240/74551f1c-89fd-4264-a494-55e7d2e90e04)
