//Author-Ramkumar Muthu
//Movie Collections of a user.
Movies = new Mongo.Collection("movies");
var updatedId;
var isUpdated=false;
//This code runs on client.
if (Meteor.isClient) {
Template.body.helpers({
    genres: [
      { genre: "Genre" },
      { genre: "Foreign" },
      { genre: "Action"},
	  { genre: "Comedy"}
    ],
	//Sort the movies based on user clicking on the table header.
	movies: function () {
	switch(Session.get("sort"))
	{
		case "title":
			return Movies.find({username:Meteor.userId()}, {sort: {name: 1}});
		case "year":
			return Movies.find({username:Meteor.userId()}, {sort: {year: 1}});
		case "sortgenre":
			return Movies.find({username:Meteor.userId()}, {sort: {genre: 1}});
		default:
			return Movies.find({username:Meteor.userId()});
	}
	},
	sort: function () {
    return Session.get("sort");
  }
  });
  Template.body.events({
  //Add a movie to the user collection
  "click .moviedata" : function(event)
  {
  var title=document.getElementById("name").value;
  var Selectedyear=document.getElementById("year").value;
  var selectedgenres=document.getElementById("ddown");
  var selecteddGenre=selectedgenres.options[selectedgenres.selectedIndex].value;
  var findMovie = Movies.findOne({
  name: title,
  year: Selectedyear,
  genre:selecteddGenre
});
//Check for the null values
  if(title=="" || Selectedyear=="" || selecteddGenre=="Genre")
  {
  alert("Please enter proper values");
  return;
  }
  //Check for the year the user entered
  else if(+Selectedyear>2015 || +Selectedyear <= 1900)
  {
  alert("Year Must be in the Range of 1900 - Curerntyear");
  return;
  }
  //check whether the user entered the new movies or not
  else if(findMovie && !isUpdated)
  {
  alert("Please enter new Movie.");
  return;
  }
  //Update the movies the user entered.
  if(isUpdated)
  {
  Movies.update(updatedId, {$set: {name:title ,year:Selectedyear ,genre: selecteddGenre}});
  isUpdated=false;
  }
  //Insert the new movie to the user collection
  else
  {
	Movies.insert({
      name: title,
	  year: Selectedyear,
	  username:Meteor.userId(),
      genre: selecteddGenre
    });
  }
  document.getElementById("name").value="";
  document.getElementById("year").value="";
  document.getElementById("ddown").value="Genre";
  },
  "click .title" : function(event)
  {
	Session.set("sort","title");
  },
  "click .releaseyear" : function(event)
  {
	Session.set("sort","year");
  },
  "click .Genre" : function(event)
  {
	Session.set("sort","sortgenre");
  }
  });
  //Delete the movies based on user selection.
  Template.movie.events({
  "click .delete": function () {
    Movies.remove(this._id);
  },
  //Edit the movie based on user selection
  "click .edit": function () {
    updatedId=this._id;
	isUpdated=true;
	document.getElementById("name").value=this.name;
	document.getElementById("year").value=this.year;
	var selectedgenres=document.getElementById("ddown");
	selectedgenres.value=this.genre;
  }
  });
}