docker build --pull -t dotnetapp:ubuntu .

docker run -p 8000:80 dotnetapp:ubuntu

curl localhost:8000 