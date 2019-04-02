SELECT DISTINCT co.CONTINENT, FLOOR(AVG(ci.POPULATION))
FROM 
CITY as ci
JOIN
COUNTRY as co
ON ci.COUNTRYCODE = co.CODE
                               GROUP BY co.CONTINENT;
                               

