def get_file_extension(track,lang):
    ext = {
        'java': '.java',
        'python': '.py',
        'python3': '.py',
        'python2': '.py',
        'csharp': '.cs'
    }
    return ext[lang] or ext[track]

