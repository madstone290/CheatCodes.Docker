# ��Ŀ����������

## ������ ���� ����
```
# docker-compose.yml
version: '3'

services:
  <service1>:
    <instruction1>:
    <instruction2>:
   
  myservice:
    # build: �� ���� ��� image�� ����ؼ� �����Ѵ�. build: �� �ִ� ��� �̹��������� ���.
    image: <image>:<tag>
    
    # ���� ���丮�� �����Ѵ�. ������ ��ΰ� context�� �Ǹ� �ش� ���丮�� ��ġ�� Dockerfile�� ����ؼ� �����Ѵ�.
    build: 
    
    # ���� ���ؽ�Ʈ �� ��Ŀ������ ���� �����Ѵ�.
    build:
        # ���带 ������ ���ؽ�Ʈ
        context:
        # ���忡 ����� ��Ŀ����. ���ؽ�Ʈ���� ��� ���
        dockerfile:
    # ��Ʈ ����
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

