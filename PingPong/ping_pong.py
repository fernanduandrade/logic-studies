import turtle

#Canvas
canvas = turtle.Screen()
canvas.title("Ping Pong @fernanduandrade")
canvas.bgpic('background.gif')
canvas.update()
canvas.setup(width = 800, height = 600)
canvas.tracer(0)


#pontuação
pontos_a = 0
pontos_b = 0


#Painel esquerdo
painel_a = turtle.Turtle()
painel_a.speed(0)
painel_a.shape("square")
painel_a.color("black")
painel_a.shapesize(stretch_wid=5, stretch_len=1)
painel_a.penup()
painel_a.goto(-350, 0)


#Criando painel direito
painel_b = turtle.Turtle()
painel_b.speed(0)
painel_b.shape("square")
painel_b.color("black")
painel_b.shapesize(stretch_wid=5, stretch_len=1)
painel_b.penup()
painel_b.goto(350, 0)


#criando a bola
ball = turtle.Turtle()
ball.speed(0)
ball.shape("square")
ball.color("white")
ball.penup()
ball.goto(0, 0)
ball.dx = 0.2
ball.dy = -0.2

#Pen
pen = turtle.Turtle()
pen.speed(0)
pen.color("White")
pen.penup()
pen.hideturtle()
pen.goto(0, 250)
pen.write("JOGADOR 1: 0  JOGADOR 2: 0", align="center", font=("Courier", 24, "normal"))


#fuções
def painel_a_subir():
	y = painel_a.ycor()
	y += 20
	painel_a.sety(y)


def painel_a_descer():
	y = painel_a.ycor()
	y -= 20
	painel_a.sety(y)


def painel_b_subir():
	y = painel_b.ycor()
	y += 20
	painel_b.sety(y)


def painel_b_descer():
	y = painel_b.ycor()
	y -= 20
	painel_b.sety(y)


#keybinds 
canvas.listen()
canvas.onkeypress(painel_a_subir, "w")
canvas.onkeypress(painel_a_descer, "s")
canvas.onkeypress(painel_b_subir, "Up")
canvas.onkeypress(painel_b_descer, "Down")

#loop do game
while True:
	canvas.update()


	#mover a bola
	ball.setx(ball.xcor() + ball.dx)
	ball.sety(ball.ycor() + ball.dy)


	# aplicar fisica para voltar
	if ball.ycor() > 290:
		ball.sety(290)
		ball.dy *= -1


	if ball.ycor() < -290:
		ball.sety(-290)
		ball.dy *= -1


	if ball.xcor() > 390:
		ball.goto(0, 0)
		ball.dx *= -1
		pontos_a += 1
		pen.clear()
		pen.write("JOGADOR 1: {}  JOGADOR 2: {}".format(pontos_a, pontos_b), align="center", font=("Courier", 24, "normal"))


	if ball.xcor() < -390:
		ball.goto(0, 0)
		ball.dx *= -1
		pontos_b += 1
		pen.clear()
		pen.write("JOGADOR 1: {}  JOGADOR 2: {}".format(pontos_a, pontos_b), align="center", font=("Courier", 24, "normal"))


	#colisão da bola e o painel
	if (ball.xcor() > 340 and ball.xcor() < 350) and (ball.ycor() < painel_b.ycor() + 40 and ball.ycor() > painel_b.ycor() - 40):
		ball.setx(340)
		ball.dx *= -1
	if (ball.xcor() < -340 and ball.xcor() > -350) and (ball.ycor() < painel_a.ycor() + 40 and ball.ycor() > painel_a.ycor() - 40):
		ball.setx(-340)
		ball.dx *= -1