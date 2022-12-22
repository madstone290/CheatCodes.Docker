# ��Ŀ
��Ŀ�� ��Ŀ ����� ����Ͽ� �����񽺸� �����Ѵ�.
�ַ�� ��Ʈ���� `docker-compose up -d` �����Ѵ�.

## ����
- `book-nginx`: nginx �����̳�. �ܺ� ��û�� api/web �����̳ʷ� �����Ѵ�.
- `book-api`: api �����̳�. book api ���񽺸� �����Ѵ�.
- `book-web`: web �����̳�. book ���������� �����Ѵ�.

## ����� ���� ����
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
    

