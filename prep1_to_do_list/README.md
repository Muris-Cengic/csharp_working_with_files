# Console Activity - To Do List

## Project Overview

Create a C# console application designed as a to-do list. The application will enable users to manage their tasks efficiently with basic functionalities. 

## Features

Users should be able to:

- **Add tasks** to the list, specifying a title and the date of creation.
- **Display** the list of tasks.
- **Remove all tasks** from the list at once.
- **Save and load** the task list from a text file.

## Technical Specifications

### Task Storage Class

- Implement a **separate class** dedicated to text file manipulation. This class will encapsulate:
  - Data members related to task storage.
  - Methods for storing tasks in the file and reading tasks from the file.
  - Additional methods as deemed necessary for file manipulation.

### File Structure

- Tasks should be **saved into a text file**, one task per line.
- Each line should adhere to the following format:
  - `TASK_NAME-DATE_OF_CREATION`
	
- It's imperative that **any changes** in the list (additions, deletions) are **reflected** in the text file to ensure data integrity and continuity.

### Additional Considerations

- While the primary focus is on basic task management functionalities (add, display, remove all, save, and load), consider extending the application with more features, such as editing tasks or setting reminders, for enhanced usability.
- Ensure the application is user-friendly, with clear prompts and error messages to guide the user through various operations.
