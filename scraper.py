# make the categories for which I have to retrieve data in an array
import requests
from hr_scrapper import HR_Scrapper

TRACKS = ['java', 'python']

hr_scrap = HR_Scrapper()

for i in TRACKS:
    try:
        hr_scrap.get_track(i)
    except Exception as e:
        print('Something went wrong', str(e))