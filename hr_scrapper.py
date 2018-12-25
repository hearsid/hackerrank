import requests
from credentials import CSRF_TOKEN, COOKIE
import os
from util import get_file_extension

class HR_Scrapper:
    HEADERS = {
        'x-csrf-token': CSRF_TOKEN,
        'cookie': COOKIE
    }
    FILTERS = {
        'status': 'solved'
    }
    def __init__(self):
        return

    def get_track(self, track):
        URL = "https://www.hackerrank.com/rest/contests/master/tracks/"+track+"/challenges"
        PARAMS = {
            'offset': 0,
            'limit': 100,
            'filters': self.FILTERS,
        }
        tracks = requests.get(url=URL, params=PARAMS, headers=self.HEADERS)
        models = tracks.json()['models']
        for i in models:
            chal_slug = i.get('slug')
            sub_id = self.get_submissions(chal_slug)
            code = False
            if sub_id:
                 code = self.get_code(chal_slug, sub_id)

            if code:
                 self.create_code_file(track, chal_slug, code)

    def create_code_file(self, track, filename, code ):
        dir = './'+track
        if not os.path.isdir(dir):
            os.mkdir(dir)
            print(code, file=open('./'+track+"/"+ filename + get_file_extension(track), 'w'))

        else:
            print(code, file=open('./'+track+"/"+ filename + get_file_extension(track), 'w'))

    def get_submissions(self, chal_slug):
        PARAMS = {
            'offset': '0',
            'limit': '10'
        }
        URL = "https://www.hackerrank.com/rest/contests/master/challenges/"+chal_slug+"/submissions/?offset="+PARAMS.get('offset')+"&limit="+PARAMS.get('limit')
        submissions = requests.get(url=URL, headers= self.HEADERS)
        models = submissions.json()['models']
        if len(models) > 0:
             sub_id = models[0]['id']
             return sub_id
        else:
            return False


    def get_code(self, chal_slug, sub_id):
        URL = "https://www.hackerrank.com/rest/contests/master/challenges/"+chal_slug+"/submissions/"+str(sub_id)
        code_res = requests.get(url=URL, headers=self.HEADERS)
        model = code_res.json()['model']
        code = model['code']
        return code


