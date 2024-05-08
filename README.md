# E-commerce Application API

This repository contains ASP.NET Core application with RESTful API endpoints for e-commerce application. The API allows you to interact with products in the store.

`This is a teamwork assignment where you will work as a team within your group`

## How to work

1. One team member (admin) should fork the repo and add other members to that admin repo as collaborators.
2. The other team members should fork then clone the forked repo (the admin repo).
3. Any change/update made should be submitted to admin repo as pull request.
4. Each change should be done in a separate pull request.
5. Pull request must be reviewed by all members before merged to admin repo.
6. Admin should open a PR to the original (Integrify) repo.

Please ask your instructor or supporting instructor if you have any questions or need help.

## Database Requirements

### Level 1: Basic Requirements

* [x] For the upcoming database assignment, please design an Entity-Relationship Diagram (ERD) tailored to the project described below.

### Level 2: Additional Requirements

* [x] Create the necessary tables, define their respective columns, and provide seed data within pgAdmin.

## Backend project Requirements

### Level 1: Basic Requirements

In this level, the application includes the following features:

1. [x] Identify Entities: Identify the main entities that need to be stored in the database. These could include customers, products, categories, orders, etc.
2. [x] Define Attributes: For each entity, list and define the attributes or properties associated with it. For example, for a "customer" entity, attributes might include "id," "firstName," "lastName," "email" and so on.
3. [x] Establish Relationships: Determine the relationships between entities. Relationships can be one-to-one, one-to-many, or many-to-many. For instance, in an E-commerce system, a "customer" may have multiple "orders".
4. [x] Key: When establishing relationships, remember to create a key in your ERD to explain the notation used for relationships.
5. [x] According to the ERD above, create the entities, and build the database with Entity Framework Core.
6. [x] Create basic CRUD operations for each endpoint.
7. [x] Use authentication and role-based authorization

### Level 2: Additional Requirements

In addition to the basic requirements, the application enhances its functionality with the following features:

1. [x] Include pagination functionality to the method getting all products.
2. [ ] Implement search functionality to allow users to search for specific products based on keywords or specific fields (e.g., by title).
3. [ ] Add validation checks to ensure the data meets certain criteria before executing the actions.

### Level 3: Advanced Requirements

If you have a higher skill level and finish the previous requirements before the deadline, you can tackle the following bonus tasks:

1. [ ] Refactor method getting all books or products to also handle query parameters for filtering and sorting products based on specific criteria (e.g., price range, by title, by date, etc). Pagination still need to be integrated.
2. [ ] Use claim-based or resource-based where applicable.
3. [ ] Peer Review:
   - Review 2 assignments from other teams.
   - Provide constructive feedback and suggestions for improvement.

`Please note that the bonus requirements and reviews are optional and can be completed if you have additional time and advanced skills.`

Happy coding!

## Deadline

The deadline for the backend project is May 8th End of day (Before the presentation day)

- [ ]  Connect The database
    - Installed the packages (for db and EF core) ✅
    - Inherited from Db context in our databaseContext ✅
    - Change the type to DbSet in the db context✅
    - Add a Connection string to the database
    - we fixed the repository typing✅
    - injected databaseContext class via the Program file✅
    - updated the Product entity
    - run migrations and updating (at this point you should have the pgAdmin)
'
