--SELECT EXERCISES

SELECT *
FROM software_houses
WHERE country = 'United States';

SELECT *
FROM players
WHERE city = 'Rogahnland';

SELECT *
FROM players
WHERE name LIKE '%a';

SELECT *
FROM reviews
WHERE player_id = 800;

SELECT *
FROM tournaments
WHERE year = 2015;

SELECT *
FROM awards
WHERE description LIKE '%facere%';

SELECT DISTINCT videogame_id
FROM category_videogame
WHERE category_id = 2
OR category_id = 6;

SELECT *
FROM reviews
WHERE rating BETWEEN 2 AND 4;

SELECT *
FROM videogames
WHERE release_date LIKE '%2020%';

SELECT DISTINCT videogame_id
FROM reviews
WHERE rating = 5;


--GROUP BY EXERCISES

SELECT COUNT(*)
FROM software_houses
GROUP BY country;

SELECT COUNT(*)
FROM reviews
GROUP BY videogame_id;

SELECT COUNT(*)
FROM pegi_label_videogame
GROUP BY pegi_label_id;

SELECT COUNT(*)
FROM videogames
GROUP BY YEAR(release_date);

SELECT COUNT(*)
FROM device_videogame
GROUP BY device_id;

SELECT COUNT(*), AVG(rating)
FROM reviews
GROUP BY videogame_id;


--JOIN EXERCISES

SELECT DISTINCT player_id
FROM reviews
INNER JOIN players
ON player_id = reviews.player_id;

SELECT DISTINCT videogame_id
FROM videogames
INNER JOIN tournament_videogame
ON videogames.id = tournament_videogame.tournament_id
INNER JOIN tournaments
ON tournament_videogame.tournament_id = tournaments.id
WHERE year = 2016;

SELECT *
FROM videogames
INNER JOIN category_videogame
ON videogames.id = category_videogame.category_id
INNER JOIN categories
ON category_videogame.category_id = categories.id;

SELECT *
FROM software_houses
INNER JOIN videogames
ON software_house_id = videogames.id
WHERE YEAR(release_date) > 2020;

SELECT *
FROM awards
INNER JOIN award_videogame
ON awards.id = award_videogame.award_id
INNER JOIN videogames
ON award_videogame.award_id = videogames.id
INNER JOIN software_houses
ON software_houses.id = software_house_id;

SELECT DISTINCT videogames.name, categories.name, pegi_labels.name
FROM videogames
INNER JOIN category_videogame
ON videogames.id = category_videogame.videogame_id
INNER JOIN categories
ON category_videogame.category_id = categories.id
INNER JOIN pegi_label_videogame
ON videogames.id = pegi_label_videogame.videogame_id
INNER JOIN pegi_labels
ON pegi_label_videogame.pegi_label_id = pegi_labels.id
INNER JOIN reviews
ON videogames.id = reviews.videogame_id
WHERE reviews.rating BETWEEN 4 AND 5;
