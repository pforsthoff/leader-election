Running Redis locally in Docker

docker run --name some-redis -p 6379:6379 -d redis redis-server --appendonly yes