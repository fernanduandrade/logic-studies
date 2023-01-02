estacoes_st = set(['mt', 'wa', 'or', 'id', 'nv', 'ut', 'ca'])
estacoes = {
  'kum': set(['id', 'nv', 'ut']),
  'kdois': set(['wa', 'id', 'mt']),
  'ktres': set(['or', 'nv', 'ca']),
  'kquatro': set(['nv', 'ut']),
  'kcinco': set(['ca', 'az'])
}


estacios_final = {}
melhor_estacao = None
estados_cobertos = set()

for estacao, estados_por_estacao in estacoes.items():
    cobertos = estacoes_st & estados_por_estacao
    if len(cobertos) > len(estados_cobertos):
      melhor_estacao = estacao
      estados_cobertos = cobertos

print(melhor_estacao)
