# ��Ŀ
��Ŀ �� ��Ŀ ����� ����Ͽ� �����񽺸� �����Ѵ�.
�ΰ��� ����� �����Ѵ�.
- ��Ʈ������
- ����ȣ��Ʈ

## ��Ʈ������ ���
�ַ�� ��Ʈ���� `docker-compose up -d` �����Ѵ�.

### ����
- `book-nginx`: nginx �����̳�. �ܺ� ��û�� api/web �����̳ʷ� �����Ѵ�.
- `book-api`: api �����̳�. book api ���񽺸� �����Ѵ�.
- `book-web`: web �����̳�. book ���������� �����Ѵ�.

### ����� ���� ����
`docker-compose.yml`���Ͽ��� ��Ȳ�� �°� ������ �����Ѵ�.

- `book-nginx` �����̳�
	- ports
    	- ssl port: ssl ��Ʈ��ȣ
        - http port: http ��Ʈ��ȣ
    - environment
        - API_PORT: api�����̳��� ��Ʈ��ȣ
        - WEB_PORT: web�����̳��� ��Ʈ��ȣ
- `book-api` �����̳�
    - ports
        - http port: api�����̳��� ��Ʈ��ȣ�� �����Ѵ�. nginx�����̳ʿ��� �� ��Ʈ��ȣ�� �����Ѵ�.
- `book-web` �����̳�
    - ports
        - http port: web�����̳��� ��Ʈ��ȣ�� �����Ѵ�. nginx�����̳ʿ��� �� ��Ʈ��ȣ�� �����Ѵ�.
    - command
        - ApiUrl: �����񽺿��� ����� api������ url�� �����Ѵ�. /�� ������ �Ѵ�. ex) ApiUrl=http://host.com/
    
## ����ȣ��Ʈ ���
`jwilder/nginx-proxy`�� �̿��Ͽ� ����ȣ��Ʈ�� �����̳ʸ� �ĺ��Ѵ�.
`hosts`������ �����Ͽ� `api.book`, `web.book` ȣ��Ʈ�� ����Ѵ�. 

```
# �̹��� ����. ����ȣ��Ʈ ��� �̹����� v2�±׸� ����Ѵ�.
# �ַ�� ��Ʈ����
docker build -t book-api:v2 -f BookApi\Dockerfile .
docker build -t book-web:v2 -f BookWebApp\Dockerfile .

# nginx���Ͻ� �����̳� ����
docker run -d -p 80:80 -v /var/run/docker.sock:/tmp/docker.sock:ro jwilder/nginx-proxy
# api �����̳� ����
docker run -d -e VIRTUAL_HOST=api.book book-api:v2
# web �����̳� ����
docker run -d -e VIRTUAL_HOST=web.book --add-host=api.book:host-gateway book-web:v2 API_URL=http://api.book/
```

___
**NOTE**

- `VIRTUAL_HOST`�� �������� ���� �̸� ȣ��Ʈ������ ����Ѵ�.
- `--add-host` �ɼ��� ����Ͽ� �����̳ʿ��� ȣ��Ʈ�� ������ �� �ֵ��� �Ѵ�. `host-gateway`Ű����� ȣ��Ʈ�� ����Ʈ���� IP�� ��ȯ�ȴ�.

___