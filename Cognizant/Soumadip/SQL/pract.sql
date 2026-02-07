select f.foollower_id,u.first_name,u.lastname,f.following_id,u.user_id from User_table u left join folower_table f on u.user_id=f.follower_id where count(user_id)>5



select u.first_name,u.lastname,count(f.following_id),u.user_id as follower_id from User_table u left join folower_table f on u.user_id=f.follower_id where count(user_id)>5