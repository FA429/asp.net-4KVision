# Library/E-commerce Application API

This repository contains ASP.NET Core application with RESTful API endpoints for a library or e-commerce application. The API allows you to interact with items in the library or products in the store.

`This is a teamwork assignment where you will work as a team within your group`

## How to work

1. One team member should fork the repo.
2. The other team members should clone the forked repo (your team member's forked repo).
3. All team members now work from the origin repository.
4. The member who forked the repo should open a PR

Please ask your instructor or supporting instructor if you have any questions or need help.

## Level 1: Basic Requirements

In this level, the application includes the following features:

1. Identify Entities: For your chosen project, identify the main entities that need to be stored in the database. These could include customers, products, orders, books, authors, category, etc.
2. Define Attributes: For each entity, list and define the attributes or properties associated with it. For example, for a "customer" entity, attributes might include "id," "firstName," "lastName," "email" and so on.
3. Establish Relationships: Determine the relationships between entities. Relationships can be one-to-one, one-to-many, or many-to-many. For instance, in an E-commerce system, a "customer" may have multiple "orders".
4. Key: When establishing relationships, remember to create a key in your ERD to explain the notation used for relationships.
5. According to the ERD above, create the entities, and build the database with Entity Framework Core.
6. Create basic CRUD operations for users and products endpoints.

## Level 2: Additional Requirements

In addition to the basic requirements, the application enhances its functionality with the following features:

1. Include pagination functionality to the method getting all items or products.
2. Implement search functionality to allow users to search for specific items or products based on keywords or specific fields (e.g., by title, by author).
3. Add validation checks to ensure the data meets certain criteria before executing the actions.

## Level 3: Bonus Requirements (Optional)

If you have a higher skill level and finish the previous requirements before the deadline, you can tackle the following bonus tasks:

1. Refactor method getting all items or products to also handle query parameters for filtering and sorting items or products based on specific criteria (e.g., price range, by title, by date, etc). Pagination still need to be integrated.
2. Integrate authentication and authorization mechanisms to secure all the sensitive API endpoints.
3. Peer Review:
   - Review 2 assignments from teams.
   - Provide constructive feedback and suggestions for improvement.

`Please note that the bonus requirements and reviews are optional and can be completed if you have additional time and advanced skills.`

Happy coding!
