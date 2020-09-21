from flask import Flask, request, jsonify
import json
import Final, new

#['shortness of breath', 'dizziness', 'headache']
app = Flask(__name__)

@app.route('/test/<s>', methods=['GET', 'POST'])
def test(s):
    if request.method == "GET":
        return jsonify({"resposnse": "Get Request Called"})
    elif request.method == "POST":
        x=new.pred(s)
        #req_Json = request.json
        #name = req_Json['name']
        #return jsonify({"Responst": "Hi"+name})
        return x

if __name__ == '__main__':
    app.run(debug=True)