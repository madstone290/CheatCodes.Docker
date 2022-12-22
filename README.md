# 도커
도커를 도커 컴포즈를 사용하여 웹서비스를 제공한다.
솔루션 루트에서 `docker-compose up -d` 실행한다.

## 구성
- `book-nginx`: nginx 컨테이너. 외부 요청을 api/web 컨테이너로 전달한다.
- `book-api`: api 컨테이너. book api 서비스를 제공한다.
- `book-web`: web 컨테이너. book 웹페이지를 제공한다.

## 사용자 설정 변수
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
    

