# 도커파일 명령어

## FROM
- `FROM <image>`
- `FROM <image>:<tag>`
- `FROM <image>@<digest>`
___
- 베이스 이미지를 지정한다

## MAINTAINER
- `MAINTAINER <name>`
___
- 이미지의 Author항목을 설정한다.

## RUN
- `RUN <command>` (shell form)
- `RUN ["<executable>", "<param1>", "<param2>"]` (exec form)
___
- 이미지 빌드 중 컨테이너 안에서 명령어를 실행한다.

## CMD
- `CMD ["<executable>","<param1>","<param2>"]` (exec form, preferred form)
- `CMD ["<param1>","<param2>"]` (ENTRYPOINT에 인자로 전달된다)
- `CMD <command> <param1> <param2>` (shell form)
___
- 컨테이너 시작될 때 실행할 명령어를 설정한다. 
- ENTRYPOINT가 존재하는 경우 명령어가 실행되지 않고 ENTRYPOINT의 인자로 전달된다.
- 여러개의 CMD가 있는 경우 마지막 하나만 적용된다.

## ENTRYPOINT
- `ENTRYPOINT ["<executable>", "<param1>", "<param2>"]` (exec form, preferred)
- `ENTRYPOINT <command> <param1> <param2>` (shell form)
___
- 컨테이너가 시작될 때 실행할 명령어를 설정한다.
- 여러개의 ENTRYPOINT가 있는 경우 마지막 하나만 적용된다.

___
**NOTE**
ENTRYPOINT에 컨테이너에서 실행할 기본 명령어를 설정하고
CMD에 인자를 전달하자.
___

## EXPOSE
- `EXPOSE <port> [<port> ...]`
___
- 컨테이너 실행시에 수신할 포트번호를 설정한다.

## ENV
- `ENV <key> <value>`
- `ENV <key>=<value> [<key>=<value> ...]`
___
- 환경변수를 설정한다

## ADD
- `ADD <src> [<src> ...] <dest>`
- `ADD ["<src>", ... "<dest>"]` (this form is required for paths containing whitespace)
___
- 파일을 복사하고 압축 해제 등의 동작을 제공한다.
- 경로에 URL을 사용할 수 있다.

## COPY
- `COPY <src> [<src> ...] <dest>`
- `COPY ["<src>", ... "<dest>"]` (this form is required for paths containing whitespace)
___
- 파일을 복사한다. 복사만 하며 다른 동작은 일어나지 않는다.

## VOLUME
- `VOLUME ["<path>", ...]`
- `VOLUME <path> [<path> ...]`
___
- 볼륨 마운트를 설정한다.

## WORKDIR
- `WORKDIR </path/to/workdir>`
___
- 다음 명령어를 실행할 작업 디렉토리를 설정한다.
- `RUN`, `CMD`, `ENTRYPOINT`, `COPY`, `ADD`

## ARG
- `ARG <name>[=<default value>]`
___
- 빌드시에 사용할 변수를 정의한다.

## 참조
- [도커파일 레퍼런스](https://docs.docker.com/engine/reference/builder/)
- [도커파일 Best practices](https://docs.docker.com/develop/develop-images/dockerfile_best-practices/)

