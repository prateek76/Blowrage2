# Blowrage2
A bridge crossing game challange ver 2.0

#### Watch gameplay here [YOUTUBE](https://www.youtube.com/watch?v=Q9dzwiYps1c)

## Built With

* UNITY
* C#

## game working links

* [GitHub](https://prateek76.github.io/Blowrage2/) Github hosted
* [itch](https://prateek76.itch.io/blowrage) itch.io hosted
* [Download for windows](https://doc-0s-bc-docs.googleusercontent.com/docs/securesc/ha0ro937gcuc7l7deffksulhg5h7mbp1/3ehktfaucjg862mkgh9ud1q6frvmog49/1541952000000/16880230332876410989/*/1o-Ju1y0HyvEsY8Ustoieo3zo6crrllXs?e=download)



## Development setup

Install unity in your WINDOWS

```sh
open unity -> open project -> open sourceCode folder
```

```sh
Start development
```


## Installation

Windows & Linux:

```sh
git clone https://github.com/prateek76/Blowrage2.git
```


```sh
open unity -> open project -> open sourceCode folder
```

```sh
go to file -> build
```

that's it

## Screenshots
<img src="https://prateek76.github.io/Blowrage2/screen/1.png" width="800">

<img src="https://prateek76.github.io/Blowrage2/screen/2.png" width="800">

<img src="https://prateek76.github.io/Blowrage2/screen/3.png" width="800">

<img src="https://prateek76.github.io/Blowrage2/screen/4.png" width="800">

<img src="https://prateek76.github.io/Blowrage2/screen/5.png" width="800">


## Authors

* **Prateek** 

101

1. Client/Server model using tcp
nc -l 1234 //To listen
nc 127.0.0.1 1234 // To send

2. Client Server model using udp
nc -u -l 1234
nc -u 172.20.34.108 1234

3. Data transfer using tcp
nc -l port > received file
nc ip port < sending file

4. Data transfer using udp
nc -u -l port > received file
nc -u ip port < sending file

5. port scanning
nc -z host.example.com 20-30

6. Open a TCP connection to port 42 of host.example.com, using port 31337 as the source port, with a timeout of 5 seconds:
$ netcat -p 31337 -w 5 host.example.com 42

7. Open a UDP connection to port 53 of host.example.com:
$ netcat -u host.example.com 53

8. Open a TCP connection to port 42 of host.example.com using 10.1.2.3 as the IP for the local end of the connection:
$ netcat -s 10.1.2.3 host.example.com 42

9.Create and listen on a UNIX-domain stream socket:
$ netcat -lU /var/tmp/dsocket

10. Connect to port 42 of host.example.com via an HTTP proxy at 10.2.3.4, port 8080. This example could also be used by ssh; see the ProxyCommand directive in ssh_config(5) for more information.
$ netcat -x10.2.3.4:8080 -Xconnect host.example.com 42

11. The same example again, this time enabling proxy authentication with username ``ruser'' if the proxy requires it:
$ netcat -x10.2.3.4:8080 -Xconnect -Pruser host.example.com 42
