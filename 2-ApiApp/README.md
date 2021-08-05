docker build -t aspnetapp .
docker run  -p 5000:80 -p 5001:80  --name myapp aspnetapp