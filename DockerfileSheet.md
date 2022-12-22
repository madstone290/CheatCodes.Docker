# ��Ŀ���� ��ɾ�

## FROM
- `FROM <image>`
- `FROM <image>:<tag>`
- `FROM <image>@<digest>`
___
- ���̽� �̹����� �����Ѵ�

## MAINTAINER
- `MAINTAINER <name>`
___
- �̹����� Author�׸��� �����Ѵ�.

## RUN
- `RUN <command>` (shell form)
- `RUN ["<executable>", "<param1>", "<param2>"]` (exec form)
___
- �̹��� ���� �� �����̳� �ȿ��� ��ɾ �����Ѵ�.

## CMD
- `CMD ["<executable>","<param1>","<param2>"]` (exec form, preferred form)
- `CMD ["<param1>","<param2>"]` (ENTRYPOINT�� ���ڷ� ���޵ȴ�)
- `CMD <command> <param1> <param2>` (shell form)
___
- �����̳� ���۵� �� ������ ��ɾ �����Ѵ�. 
- ENTRYPOINT�� �����ϴ� ��� ��ɾ ������� �ʰ� ENTRYPOINT�� ���ڷ� ���޵ȴ�.
- �������� CMD�� �ִ� ��� ������ �ϳ��� ����ȴ�.

## ENTRYPOINT
- `ENTRYPOINT ["<executable>", "<param1>", "<param2>"]` (exec form, preferred)
- `ENTRYPOINT <command> <param1> <param2>` (shell form)
___
- �����̳ʰ� ���۵� �� ������ ��ɾ �����Ѵ�.
- �������� ENTRYPOINT�� �ִ� ��� ������ �ϳ��� ����ȴ�.

___
**NOTE**
ENTRYPOINT�� �����̳ʿ��� ������ �⺻ ��ɾ �����ϰ�
CMD�� ���ڸ� ��������.
___

## EXPOSE
- `EXPOSE <port> [<port> ...]`
___
- �����̳� ����ÿ� ������ ��Ʈ��ȣ�� �����Ѵ�.

## ENV
- `ENV <key> <value>`
- `ENV <key>=<value> [<key>=<value> ...]`
___
- ȯ�溯���� �����Ѵ�

## ADD
- `ADD <src> [<src> ...] <dest>`
- `ADD ["<src>", ... "<dest>"]` (this form is required for paths containing whitespace)
___
- ������ �����ϰ� ���� ���� ���� ������ �����Ѵ�.
- ��ο� URL�� ����� �� �ִ�.

## COPY
- `COPY <src> [<src> ...] <dest>`
- `COPY ["<src>", ... "<dest>"]` (this form is required for paths containing whitespace)
___
- ������ �����Ѵ�. ���縸 �ϸ� �ٸ� ������ �Ͼ�� �ʴ´�.

## VOLUME
- `VOLUME ["<path>", ...]`
- `VOLUME <path> [<path> ...]`
___
- ���� ����Ʈ�� �����Ѵ�.

## WORKDIR
- `WORKDIR </path/to/workdir>`
___
- ���� ��ɾ ������ �۾� ���丮�� �����Ѵ�.
- `RUN`, `CMD`, `ENTRYPOINT`, `COPY`, `ADD`

## ARG
- `ARG <name>[=<default value>]`
___
- ����ÿ� ����� ������ �����Ѵ�.

## ����
- [��Ŀ���� ���۷���](https://docs.docker.com/engine/reference/builder/)
- [��Ŀ���� Best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/)

