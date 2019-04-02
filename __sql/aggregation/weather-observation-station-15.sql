select round(LONG_W, 4) from sTation WHERE
LAT_N = (select max(LAT_n) from STATION WHERE LAT_N < 137.2345)
