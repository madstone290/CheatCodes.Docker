# 도커
도커 및 도커 컴포즈를 사용하여 웹서비스를 제공한다.
두가지 방식을 제공한다.
- 포트포워딩
- 가상호스트

## 포트포워딩 방식
솔루션 루트에서 `docker-compose up -d` 실행한다.

### 구성
- `book-nginx`: nginx 컨테이너. 외부 요청을 api/web 컨테이너로 전달한다.
- `book-api`: api 컨테이너. book api 서비스를 제공한다.
- `book-web`: web 컨테이너. book 웹페이지를 제공한다.

### 사용자 설정 변수
`docker-compose.yml`파일에서 상황에 맞게 변수를 설정한다.

- `book-nginx` 컨테이너
	- ports
    	- ssl port: ssl 포트번호
        - http port: http 포트번호
    - environment
        - API_PORT: api컨테이너의 포트번호
        - WEB_PORT: web컨테이너의 포트번호
- `book-api` 컨테이너
    - ports
        - http port: api컨테이너의 포트번호를 설정한다. nginx컨테이너에서 이 포트번호로 전달한다.
- `book-web` 컨테이너
    - ports
        - http port: web컨테이너의 포트번호를 설정한다. nginx컨테이너에서 이 포트번호로 전달한다.
    - command
        - ApiUrl: 웹서비스에서 사용할 api서비스의 url를 설정한다. /로 끝나야 한다. ex) ApiUrl=http://host.com/
    
## 가상호스트 방식
`jwilder/nginx-proxy`를 이용하여 가상호스트로 컨테이너를 식별한다.
`hosts`파일을 수정하여 `api.book`, `web.book` 호스트를 등록한다. 

```
# 이미지 빌드. 가상호스트 방식 이미지는 v2태그를 사용한다.
# 솔루션 루트에서
docker build -t book-api:v2 -f BookApi\Dockerfile .
docker build -t book-web:v2 -f BookWebApp\Dockerfile .

# nginx프록시 컨테이너 실행
docker run -d -p 80:80 -v /var/run/docker.sock:/tmp/docker.sock:ro jwilder/nginx-proxy
# api 컨테이너 실행
docker run -d -e VIRTUAL_HOST=api.book book-api:v2
# web 컨테이너 실행
docker run -d -e VIRTUAL_HOST=web.book --add-host=api.book:host-gateway book-web:v2 API_URL=http://api.book/
```

___
**NOTE**

- `VIRTUAL_HOST`에 도메인을 적고 이를 호스트명으로 사용한다.
- `--add-host` 옵션을 사용하여 컨테이너에서 호스트로 연결할 수 있도록 한다. `host-gateway`키워드는 호스트의 게이트웨이 IP로 변환된다.

___