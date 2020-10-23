## Michael's Dev Notes
This is just a place for me to jot notes as I'm working on the assignment.

### Approach
Keep it focused. I'm personally very limited on time, so avoid feature creep.

For speed, I'll start with a default VS2019 ASP.Net Core WebAPI project, no auth, no encryption, no db.

### Assumptions
Starting assumptions
- No UI, use Swagger
- No DB, mock data in static classes
  - This means that posts won't actually record data...
- Assume authenticated user
- Log to default logger

More assumptions
- CityId: there's half a dozen ways to paramatarize a city (zip code, name, name+state, geolocation, neighborhood). For simplicity, I went with an internal CityId... which likely isn't the optimal solution
  
  

### Issues
(Place for problems, questions)

Do they expect a database behind this? It wouldn't be that involved, but I legit only have a few hours.


### ToDo
- [x] Create new VS project
- [x] Add Swagger
- [x] Create Restaurant Contoller
  - [] GetRestaurantsByCity
  - [] AddRestaurant
- [] Create Review Controller
  - [] AddReview
  - [] GetReviewsByUser
  - [] DeleteReview
- [x] Create Restaurant Service / Model / Tests
  - [] GetRestaurantsByCity
  - [] AddRestaurant
- [] Create Review Service / Model / Tests
  - [] AddReview
  - [] GetReviewsByUser
  - [] DeleteReview
- [] Confirm app appears working
- [] Confirm tests working
- [] Confirm documentation
- [] Add instructions on how to run to Readme.md

### Misc Notes

GetRestaurantsByCity: Get a list of restaurants by city  
AddRestaurant: Post a restaurant that is not in the database

AddReview: Post a review for a restaurant
GetReviewsByUser: Get of a list of reviews by user
DeleteReview: Delete a review