/*
Enter your query here.
*/
SELECT concat(Name,concat('(', SUBSTRING(Occupation, 1, 1), ')')) AS Osc FROM OCCUPATIONS ORDER BY Name ASC;
SELECT concat('There are a total of ', count(Occupation),' ', lower(Occupation), 's.') FROM OCCUPATIONS GROUP BY Occupation ORDER BY count(Occupation), Occupation ASC ;
