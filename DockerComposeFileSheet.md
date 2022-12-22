# 도커컴포즈파일

## 컴포즈 파일 형식
```
# docker-compose.yml
version: '3'

services:
  <service1>:
    <instruction1>:
    <instruction2>:
   
  myservice:
    # build: 가 없는 경우 image를 사용해서 빌드한다. build: 가 있는 경우 이미지명으로 사용.
    image: <image>:<tag>
    
    # 빌드 디렉토리를 설정한다. 지정한 경로가 context가 되며 해당 디렉토리에 위치한 Dockerfile을 사용해서 빌드한다.
    build: 
    
    # 빌드 컨텍스트 및 도커파일을 직접 지정한다.
    build:
        # 빌드를 진행할 컨텍스트
        context:
        # 빌드에 사용할 도커파일. 컨텍스트에서 상대 경로
        dockerfile:
    # 포트 맵핑
    ports:
      - <host-port>:<container-port>
      - 8000:80
      - 8001:443
    
    volumes:
     - <host-path>:<container-path>
     - /nginx.conf:/etc/nginx/nginx.conf

    command: <command>
    or
    command: [<arg1>, <arg2>, ...]

    environment:
        - <key>=<value>
        - NAME=JOHN
        - AGE=30
  
```

