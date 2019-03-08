# make the categories for which I have to retrieve data in an array
import requests
from hr_scrapper import HR_Scrapper
import logging
import requests
import threading

logging.basicConfig(filename="logs.txt")
TRACKS = ['java', 'python', 'tutorials', 'algorithms', 'data-structures', 'mathematics', '10-days-of-statistics']

hr_scrap = HR_Scrapper()

for i in TRACKS:
    try:
        t1 = threading.Thread(target=hr_scrap.get_track, args=(i,))
        t1.start();
        #hr_scrap.get_track(i)
    except Exception as e:
        print('Something went wrong::', str(e))
        logging.warning(e)
        pass

    except requests.exceptions.HTTPError as errh:
        print("Http Error:", errh)
        pass
