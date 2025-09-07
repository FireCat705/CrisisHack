# CrisisHack
Our project [placeholder] is a map-based system to help those in the aftermath of natural disasters navigate to safety or shelter as they wait to evacuate to safer areas.

1 -- The first opening page is a map based on the user's location ( it would be Google Map API, but that costs money so we used a photo as example ), on top of which there are various pins placed by other users such as warning pins ( fire, flood, blockage, downed power line ) and ones that provide ( water, food, shelter, medic ). Every pin placed by one user is visible to every other user and can be removed if it is no longer applicable. 

2 -- From the drop down menu, we can access then the Chat section which is more of a message board of posts of everyone in a certain radius surrounding area. Posts can be deleted and are prioritized by tags in their subject headers ( # HELP triggers a fire symbol and is 1st priority used for when a user needs immediate help, whether it be that they are seriously injured or blocked.

Following tags are #need water with a water symbol, #has water-- same symbol, and #need food and #has food and #need medic and #has medic, all with corrosponding symbols. Normal text posts are lowest priority. ) Clicking a post displays the full post with time of uploading. Posts can be deleted by the user who made it if the situation is resolved as to not clog the message board.

3 -- From the same drop down menu, users can access Settings which includes Dark and Light Mode and the Deadman's Switch-- a custom switch which is set to broadcast a user's location to everyone else in neighboring areas if they do not use the app in a certain amount of days and hours set by the user. The user is pinged in the preceding 'grace period' before the Switch goes off to prevent accidentally setting it off. 
4 -- Lastly, we weren't able to finish this feature, but we have a mockup of it -- where using Google Map API we could have a user use navigation to navigate from their current location to a chosen one, whether that be a place where there are pins for shelter, water, etc., automatically avoiding roads and areas with warning pins ( fire, flood, etc. ).
